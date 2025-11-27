using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UIInventoryPanel uiInventoryPanel;
    
    public void UpdatePlayerInfo()
    {
        uiInventoryPanel.ClearSlot();
        uiInventoryPanel.UpdateSlots();
    }
    
}
