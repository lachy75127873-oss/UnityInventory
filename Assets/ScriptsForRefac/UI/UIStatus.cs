using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("ReturnButton")]
    
    [Header("Status Info")]
    [SerializeField] private GameObject statusInfoPanel;
    
    private Player _player;
    private UIStatusPanel statusPanel;
    private bool lastStatus;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        lastStatus = UIManager.Instance.onStatus;
        
        _player = GameManager.Instance.Player;
        
        statusPanel =  statusInfoPanel.GetComponent<UIStatusPanel>();
    }

    private void ReturnMainMenu()
    {
        UIManager.Instance.ToggleStatusInfo();
    }
    
    public void UpdatePlayerInfo()
    {
        statusPanel.ClearSlot();
        statusPanel.UpdateSlots();
    }
    
}
