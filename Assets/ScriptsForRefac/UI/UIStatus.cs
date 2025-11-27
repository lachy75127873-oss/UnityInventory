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
    [SerializeField]private UIStatusPanel statusPanel;

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
