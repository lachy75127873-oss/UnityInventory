using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class UIManager: Singleton<UIManager>
{
    [FormerlySerializedAs("mainMenu")]
    [Header("UI프리팹")]
    [SerializeField]private GameObject mainMenuPrefab;
    [SerializeField]private GameObject statusInfoPrefab;
    [SerializeField]private GameObject inventoryInfoPrefab;

    public GameObject mainM;
    public GameObject statusI;
    public GameObject inventoryI;
    public UIMainmenu uiMainMenu; 

    public bool onStatus;
    public bool onInventory;

    #region UIManager 초기화 관련
    protected override void Init()
    {
        //이밴트시스템 검사
        if (EventSystem.current == null)
        {
            Debug.Log("이밴트 시스템이 없습니다.");
            
            GameObject newEventSys = new GameObject("EventSystem");
            EventSystem eventSystem = newEventSys.AddComponent<EventSystem>();
            eventSystem.AddComponent<StandaloneInputModule>();
        }
        else Debug.Log("이밴트 시스템이 있습니다.");
        
        //UI오브젝트 준비
        InitUI();
        
        //UI오브젝트 검사
        Debug.Log("Initializing UIManager");
        if (mainMenuPrefab == null)
        {
            Debug.Log("UIManager: mainMenu is null");
            return;
        }
        if (statusInfoPrefab == null)
        {
            Debug.Log("UIManager: statusInfo is null");
            return;
        }
        if (inventoryInfoPrefab == null)
        {
            Debug.Log("UIManager: inventoryInfo is null");
            return;
        }
        
        //메인메뉴 객체에 신호
        uiMainMenu.ReadyMainMenu();
        Debug.Log("UI준비 완료");
    }

    public void InitUI()
    {
        //관련 프리팹 로드
        mainMenuPrefab = Resources.Load<GameObject>("Prefabs/UI/UIMainMenu");
        statusInfoPrefab = Resources.Load<GameObject>("Prefabs/UI/Status/UIStatus");
        inventoryInfoPrefab = Resources.Load<GameObject>("Prefabs/UI/Inventory/UIInventory");
        
        //프리팹 복제
        mainM = Instantiate(mainMenuPrefab);
        statusI = Instantiate(statusInfoPrefab);
        inventoryI = Instantiate(inventoryInfoPrefab);
        
        //초기화
        statusI.SetActive(false);
        inventoryI.SetActive(false);
        mainM.SetActive(true);
         onStatus = false; 
         onInventory = false;
        
        //메인메뉴 참조
        uiMainMenu = mainM.GetComponent<UIMainmenu>();
    }

    #endregion

    #region 상태창, 인밴토리 및 버튼 토글

    public void ToggleStatusInfo()
    {
        onStatus = !onStatus;
        statusI.SetActive(onStatus);
        uiMainMenu.ToggleBtns();
    }

    public void ToggleInventoryInfo()
    {
        onInventory = !onInventory;
        inventoryI.SetActive(onInventory);
        uiMainMenu.ToggleBtns();
    }

    public void ReturnToMainMenu()
    {
        if (onStatus) ToggleStatusInfo();
        if (onInventory) ToggleInventoryInfo();
    }

    #endregion
    
  
    
}
