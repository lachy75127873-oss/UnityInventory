using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainmenu : MonoBehaviour
{
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    private void Start()
    {
        Init();
        Debug.Log("UIMainmenu Start");
    }

    private void OnDisable()
    {
        statusButton.onClick.RemoveAllListeners();
        inventoryButton.onClick.RemoveAllListeners();
    }

    private void Init()
    {
        Debug.Log("UIMainMenu Init");
        if (statusButton == null)
        {
            Debug.Log("UIMainMenu statusButton is null");
        }

        if (inventoryButton == null)
        {
            Debug.Log("UIMainMenu inventoryButton is null");
        }
        
        statusButton.onClick.AddListener(ShowStatusInfo);
        inventoryButton.onClick.AddListener(ShowInventory);    
        
    }
    
    private void ShowStatusInfo()
    {
       UIManager.Instance.OpenStatusInfo();
    }

    private void ShowInventory()
    {
        UIManager.Instance.OpenInventory();
    }

    
}
