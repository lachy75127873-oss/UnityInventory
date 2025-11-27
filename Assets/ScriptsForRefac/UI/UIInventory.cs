using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UIInventoryPanel uiInventoryPanel;
    
    public void UpdatePlayerInfo()
    {
        uiInventoryPanel.ClearSlot();
        uiInventoryPanel.UpdateSlots();
    }
    
}
