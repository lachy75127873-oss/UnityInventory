using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] private RawImage slotImage;
    [SerializeField] private Button slotButton;

    private ItemDataBase iDb;

    private void OnEnable()
    {
        slotButton.onClick.AddListener(ShowItemInfo);
    }

    private void OnDisable()
    {
        slotButton.onClick.RemoveListener(ShowItemInfo);
    }

    public void SetItemInfo(int itemID)
    {
        var itemData = ItemDataBase.Instance.GetItem(itemID);
        Debug.Log(itemData.idx+ "참조 ");
    }

    public void ShowItemInfo()
    {
        
    }
    
}
