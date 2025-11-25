using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("ReturnButton")]
    [SerializeField] private Button returnButton;
    
    [Header("Status Info")]
    [SerializeField] private GameObject statusInfoPanel;
    
    private Player _player;
    private UIStatusPanel statusPanel;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        returnButton.onClick.AddListener(ReturnMainMenu);
        
        _player = GameManager.Instance.Player;
        statusPanel =  statusInfoPanel.GetComponent<UIStatusPanel>();
        
        UpdatePlayerInfo();
    }

    private void ReturnMainMenu()
    {
        
        UIManager.Instance.ToggleStatusUI();
    }

    public void UpdatePlayerInfo()
    {
        statusPanel.ClearSlot();
        statusPanel.UpdateSlots();
    }
    
}
