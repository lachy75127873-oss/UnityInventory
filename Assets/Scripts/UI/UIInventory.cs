using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button returnButton;
    
    [SerializeField] private GameObject uiInventoryPanel;

    private UIInventoryPanel _uiInventoryPanel;
    
    private void Start()
    {
        Init();
    }

    private void Init()
    {
        returnButton.onClick.AddListener(ReturnMainMenu);
        _uiInventoryPanel =  uiInventoryPanel.GetComponent<UIInventoryPanel>();
        
        UpdatePlayerInfo();
    }

    private void ReturnMainMenu()
    {
        UIManager.Instance.ToggleInventoryUI();
    }
    
    private void UpdatePlayerInfo()
    {
        _uiInventoryPanel.ClearSlot();
        _uiInventoryPanel.UpdateSlots();
    }
    
}
