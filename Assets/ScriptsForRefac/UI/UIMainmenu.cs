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

    private void Awake()
    {
        Init();
        Debug.Log("UIMainmenu Init");
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
        
        player = GameManager.Instance.Player;
        Debug.Log("UI에 플레이어 등록");
        
        statusButton.onClick.AddListener(ShowStatusInfo);
        inventoryButton.onClick.AddListener(ShowInventory);    
        
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
