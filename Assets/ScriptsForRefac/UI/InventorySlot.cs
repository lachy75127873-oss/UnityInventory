using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] private RawImage slotImage;
    [SerializeField] private Button slotButton;

    private ItemData itemData;

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
        itemData = ItemDataBase.Instance.GetItem(itemID);
    }

    public void ShowItemInfo()
    {
        Debug.Log(itemData.idx + " " + itemData.name +  " " + itemData.itemType + " " + itemData.description);
    }
    
}
