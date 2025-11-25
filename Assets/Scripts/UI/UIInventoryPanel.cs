using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventoryPanel : MonoBehaviour
{
    [SerializeField] private GameObject slotPrefab;
    
    public void ClearSlot()
    {
        Transform[] childList = transform.GetComponentsInChildren<Transform>();

        for (int i = 1; i < childList.Length; i++)
        {
            Destroy(childList[i].gameObject);
        }
    }

    public void UpdateSlots()
    {
        Player player = GameManager.Instance.player;
        List<Items> pI = player.playerInventory;


        foreach (Items item in pI)
        {
            GameObject slot = Instantiate(slotPrefab, transform);
            var itemSlot = slot.GetComponent<InventorySlot>();
            
            itemSlot.SetItemInfo();
        }
    }
}
