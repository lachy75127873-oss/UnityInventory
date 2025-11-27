using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] private Button slotButton;
    [SerializeField] private Image slotImage;
    [SerializeField] private Image equipImage;

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
       slotImage.sprite = itemData.icon;
        
    }

    public void ShowItemInfo()
    {
        Debug.Log(itemData.idx + " " + itemData.name +  " " + itemData.itemType + " " + itemData.description);
    }
    
}
