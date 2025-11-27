using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject uiInventoryPanel;

    private UIInventoryPanel _uiInventoryPanel;
    
    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _uiInventoryPanel =  uiInventoryPanel.GetComponent<UIInventoryPanel>();
        
        UpdatePlayerInfo();
    }

    private void ReturnMainMenu()
    {
        UIManager.Instance.ToggleInventoryInfo();
    }
    
    private void UpdatePlayerInfo()
    {
        _uiInventoryPanel.ClearSlot();
        _uiInventoryPanel.UpdateSlots();
    }
    
}
