using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStatusPanel : MonoBehaviour
{
    
    [SerializeField] private GameObject slotPrefab;

    private StatusSlot StatusSlot;
    private int num = 0;
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
        int statCount = stats.Count;
        
        for (int i = 0; i < statCount; i++)
        {
            GameObject slot = Instantiate(slotPrefab, transform);
        }

        num = 0;
        foreach (KeyValuePair<string, int> kvp in stats)
        {
            StatusSlot = transform.GetChild(num).GetComponent<StatusSlot>();
            Debug.Log($"{num}번째 슬롯에 접근 중");
            Debug.Log(kvp.Key +":"+kvp.Value);
            StatusSlot.SetStatInfo();
            
            num++;
        }
        
    }
}
