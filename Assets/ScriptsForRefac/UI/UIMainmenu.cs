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
    
    
    private bool _onStatus;
    private bool _onInventory;
    private UIManager uiM;

    private void OnDisable()
    {
        statusButton.onClick.RemoveAllListeners();
        inventoryButton.onClick.RemoveAllListeners();
    }

    public void ReadyMainMenu()
    {
        Init();
        Debug.Log("UIMainMenu Init");
        
    }

    private void Init()
    {
        if (statusButton == null) Debug.Log("UIMainMenu statusButton is null");
        if (inventoryButton == null) Debug.Log("UIMainMenu inventoryButton is null");
        
        player = GameManager.Instance.Player;
        Debug.Log("UI에 플레이어 등록");

        uiM = UIManager.Instance;
        _onStatus = uiM.onStatus;
        _onInventory = uiM.onInventory;
        
        // Button[] buttons = GetComponentsInChildren<Button>();
        // for (int i = 0; i < buttons.Length; i++)
        // {
        //     if (buttons[i].name == "StatusBtn") statusButton = buttons[i];
        //     else if (buttons[i].name == "InventoryBtn") inventoryButton = buttons[i];
        // } 
        
        statusButton.onClick.AddListener(ToggleStatusInfo);
        inventoryButton.onClick.AddListener(ToggleInventory);    
        
        statusButton.gameObject.SetActive(true);
        inventoryButton.gameObject.SetActive(true);
        
       ShowBasicInfo();
    }

    private void ShowBasicInfo()
    {
        var playerData =  GameManager.Instance.Player.PlayerData;
        
        nameTxt.text = playerData.name;
        rankTxt.text = playerData.rank;
        descriptionTxt.text = playerData.description;
        levelTxt.text = playerData.level.ToString();
        expTxt.text = playerData.exp.ToString();
        goldTxt.text = playerData.gold.ToString();
    }
    
    public void ToggleStatusInfo()
    {
        Debug.Log("Click");
        var isOpen = uiM.onStatus;
        statusButton.gameObject.SetActive(isOpen);
        inventoryButton.gameObject.SetActive(isOpen);
        
        if (isOpen) uiM.statusI.SetActive(!isOpen);
        else uiM.statusI.SetActive(isOpen);
        
        isOpen = !isOpen;
        uiM.onStatus = isOpen;
    }

    public void ToggleInventory()
    {
        _onInventory = !_onInventory;
        statusButton.gameObject.SetActive(!_onInventory);
        inventoryButton.gameObject.SetActive(!_onInventory);
        uiM.inventoryI.gameObject.SetActive(_onInventory);
        uiM.onInventory = _onInventory;
    }
}
