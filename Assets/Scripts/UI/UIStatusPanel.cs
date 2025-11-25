using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStatusPanel : MonoBehaviour
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
        Dictionary<string,int> stats = GameManager.Instance.player.PlayerStats;
       

        foreach (KeyValuePair<string, int> kvp in stats)
        {
            GameObject slot = Instantiate(slotPrefab, transform);
            StatusSlot StatusSlot =  slot.GetComponent<StatusSlot>();
            
            StatusSlot.statusName =  kvp.Key;
            StatusSlot.statusValue = kvp.Value;
            StatusSlot.SetStatInfo();
        }
        
        // int statCount = stats.Count;
        //
        // for (int i = 0; i < statCount; i++)
        // {
        //     GameObject slot = Instantiate(slotPrefab, transform);
        // }
        //
        // int num = 0;
        // foreach (KeyValuePair<string, int> kvp in stats)
        // {
        //     var StatusSlot = transform.GetChild(num).GetComponent<StatusSlot>();
        //     Debug.Log(transform.GetChild(num));
        //     Debug.Log($"{num}번째 슬롯에 접근 중");
        //     Debug.Log(kvp.Key +":"+kvp.Value);
        //     
        //     Debug.Log(transform.GetChild(num));
        //     StatusSlot.SetStatInfo();
        //     
        //     num++;
        // }
        
    }
}
