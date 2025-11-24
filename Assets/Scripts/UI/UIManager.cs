using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;

    public static UIManager Instance
    {
        get
        {
            if (instance == null) instance = FindObjectOfType<UIManager>(); //수정 필요
            return instance;
        } 
        
    }
    
    [Header("UI프리팹")]
    [SerializeField]private GameObject mainMenu;
    [SerializeField]private GameObject statusInfo;
    [SerializeField]private GameObject inventoryInfo;

    private GameObject mM;
    private GameObject sI;
    private GameObject iI;

    private bool onStatus;
    private bool onInventory;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        //참조 검사
        if (mainMenu == null)
        {
            Debug.Log("UIManager: mainMenu is null");
            return;
        }
        if (statusInfo == null)
        {
            Debug.Log("UIManager: statusInfo is null");
            return;
        }
        if (inventoryInfo == null)
        {
            Debug.Log("UIManager: inventoryInfo is null");
            return;
        }
        
        //초기화
        InitUI();
        Debug.Log("UIManager: Init");
    }
    

    private void InitUI()
    {
        //그 전에 다른 게임오브젝트 청소
        
        mM = Instantiate(mainMenu);
        sI = Instantiate(statusInfo);
        iI = Instantiate(inventoryInfo);
        
        mM.SetActive(true);
        sI.SetActive(false);
        iI.SetActive(false);

        onStatus = false; 
        onInventory = false;
    }
    
    public void ToggleStatusUI()
    {
        onStatus = !onStatus;
        sI.SetActive(onStatus);
    }

    public void ToggleInventoryUI()
    {
        onInventory = !onInventory;
        iI.SetActive(onInventory);
    }
    
}
