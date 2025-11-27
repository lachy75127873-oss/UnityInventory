using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStatusPanel : MonoBehaviour
{
    
    [SerializeField] private GameObject slotPrefab;
    
    private StatImageData imageData;
    
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
        imageData = UIManager.Instance.uiStatImageData;
        
        var pCd = GameManager.Instance.Player.PlayerCondition;
        Dictionary<string,int> stats = GameManager.Instance.Player.PlayerCondition.conditions;
        
        foreach (KeyValuePair<string, int> kvp in stats)
        {
            GameObject slot = Instantiate(slotPrefab, transform);
            StatusSlot StatusSlot =  slot.GetComponent<StatusSlot>();
            
            StatusSlot.statusName =  kvp.Key;
            StatusSlot.statusValue = kvp.Value; ;
          //  StatusSlot.statusIcon = imageData[kvp.Key];
            StatusSlot.SetStatInfo();
        }
    }
}
