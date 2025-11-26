using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainmenu : MonoBehaviour
{
    [Header("Main Menu")]
    
    [Header("Buttons")]
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;
    
    [Header("Basic Info Text")]
    [SerializeField] private TextMeshProUGUI nameTxt;
    [SerializeField] private TextMeshProUGUI rankTxt;
    [SerializeField] private TextMeshProUGUI descriptionTxt;
    [SerializeField] private TextMeshProUGUI levelTxt;
    [SerializeField] private TextMeshProUGUI expTxt;
    [SerializeField] private TextMeshProUGUI goldTxt;
    
    Player player;
    
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
        
        player = GameManager.Instance.Player;
        ShowBasicInfo();
    }

    private void ShowBasicInfo()
    {
        // nameTxt.text = player.Name;
        // rankTxt.text = player.Rank;
        // descriptionTxt.text = player.Description;
        // levelTxt.text = player.Level.ToString();
        // expTxt.text = player.Exp.ToString();
        // goldTxt.text = player.Gold.ToString()+ "gold";
    }
    
    private void ShowStatusInfo()
    {
       UIManager.Instance.ToggleStatusUI();
    }

    private void ShowInventory()
    {
        UIManager.Instance.ToggleInventoryUI();
    }

    public void HideButtons(bool isHide)
    {
        statusButton.gameObject.SetActive(!isHide);
        inventoryButton.gameObject.SetActive(!isHide);
    }

    
}
