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
        var pI = GameManager.Instance.Player.PlayerInventory;
        
         foreach (KeyValuePair<int,int> kv in pI)
         {
             GameObject slot = Instantiate(slotPrefab, transform);
             var itemSlot = slot.GetComponent<InventorySlot>();
             
             Debug.Log(kv.Key + " " + kv.Value);
             itemSlot.SetItemInfo(kv.Key);
         }
    }
}
