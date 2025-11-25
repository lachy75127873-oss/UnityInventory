using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager: Singleton<UIManager>
{
    
    [Header("UI프리팹")]
    [SerializeField]private GameObject mainMenu;
    [SerializeField]private GameObject statusInfo;
    [SerializeField]private GameObject inventoryInfo;
    
    private UIMainmenu uiMainmenu;

    private GameObject mM; //MainMenu
    private GameObject sI; //StatusInfo
    private GameObject iI; //InventoryInfo

    public bool onStatus;
    public bool onInventory;
    
    protected override void Init()
    {
        Debug.Log("Initializing UIManager");
    }
    
    // private void Awake()
    // {
    //     //참조 검사
    //     if (mainMenu == null)
    //     {
    //         Debug.Log("UIManager: mainMenu is null");
    //         return;
    //     }
    //     if (statusInfo == null)
    //     {
    //         Debug.Log("UIManager: statusInfo is null");
    //         return;
    //     }
    //     if (inventoryInfo == null)
    //     {
    //         Debug.Log("UIManager: inventoryInfo is null");
    //         return;
    //     }
    //     
    //     //초기화
    //     InitUI();
    //     Debug.Log("UIManager: Init");
    // }

    public void InitUI()
    {
        //그 전에 다른 게임오브젝트 청소
        
        mM = Instantiate(mainMenu);
        sI = Instantiate(statusInfo);
        iI = Instantiate(inventoryInfo);
        
        mM.SetActive(true);
        sI.SetActive(false);
        iI.SetActive(false);

        uiMainmenu = mM.GetComponent<UIMainmenu>();
        
        onStatus = false; 
        onInventory = false;
    }
    
    public void ToggleStatusUI()
    {
        onStatus = !onStatus;
        sI.SetActive(onStatus);
        uiMainmenu.HideButtons(onStatus);
    }

    public void ToggleInventoryUI()
    {
        onInventory = !onInventory;
        iI.SetActive(onInventory);
        uiMainmenu.HideButtons(onInventory);
    }
    
}
