using UnityEngine;

public class UIStatus : MonoBehaviour
{
    [Header("ReturnButton")]
    
    [Header("Status Info")]
    [SerializeField]private UIStatusPanel statusPanel;
    
    public void UpdatePlayerInfo()
    {
        statusPanel.ClearSlot();
        statusPanel.UpdateSlots();
    }
    
}
