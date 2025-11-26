using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class UIManager: Singleton<UIManager>
{
    [Header("UI프리팹")]
    [SerializeField]private GameObject mainMenu;
    [SerializeField]private GameObject statusInfo;
    [SerializeField]private GameObject inventoryInfo;

    public GameObject mainM;
    public GameObject statusI;
    public GameObject inventoryI;
    public UIMainmenu uiMainMenu; 

    public bool onStatus;
    public bool onInventory;
    
    protected override void Init()
    {
        if (EventSystem.current == null)
        {
            Debug.Log("이밴트 시스템이 없습니다.");
            
            GameObject newEventSys = new GameObject("EventSystem");
            EventSystem eventSystem = newEventSys.AddComponent<EventSystem>();
            eventSystem.AddComponent<StandaloneInputModule>();
        }
        else Debug.Log("이밴트 시스템이 있습니다.");
        
        InitUI();
        
        Debug.Log("Initializing UIManager");
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
        
        uiMainMenu.ReadyMainMenu();
        Debug.Log("UI준비 완료");
    }

    public void InitUI()
    {
        mainMenu = Resources.Load<GameObject>("Prefabs/UI/UIMainMenu");
        statusInfo = Resources.Load<GameObject>("Prefabs/UI/Status/UIStatus");
        inventoryInfo = Resources.Load<GameObject>("Prefabs/UI/Inventory/UIInventory");
        
        uiMainMenu = mainMenu.GetComponent<UIMainmenu>();
        
        mainM = Instantiate(mainMenu);
        statusI = Instantiate(statusInfo);
        inventoryI = Instantiate(inventoryInfo);
        
        statusI.SetActive(false);
        inventoryI.SetActive(false);
        mainM.SetActive(true);
        
         onStatus = false; 
         onInventory = false;
    }
    
    // public void ToggleStatusUI()
    // {
    //     onStatus = !onStatus;
    //     statusI.SetActive(onStatus);
    //     uiMainMenu.HideButtons(onStatus);
    // }
    //
    // public void ToggleInventoryUI()
    // {
    //     onInventory = !onInventory;
    //     inventoryI.SetActive(onInventory);
    //     uiMainMenu.HideButtons(onInventory);
    // }
    
}
