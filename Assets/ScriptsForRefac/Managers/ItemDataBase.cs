using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : Singleton<ItemDataBase>
{
    [SerializeField] private List<ItemData> items;
    
    private Dictionary<int, ItemData> itemDictionary;

    public void Init()
    {
        Debug.Log("아이템 데이터 베이스 초기화중");
        itemDictionary = new Dictionary<int, ItemData>();
        foreach (var itemData in items)
        {
            itemDictionary.Add(itemData.idx, itemData);
            Debug.Log(itemData.idx +"/"+ itemData.name);
        }
    }

    public ItemData GetItem(int id)
    {
        return itemDictionary[id];
    }
    
    //아이템 데이터 검사용
    public bool TryGetItem(int id, out ItemData item)
    {
        if (itemDictionary == null)
        {
            Debug.LogError("ItemDataBase가 아직 초기화되지 않았습니다.");
            item = null;
            return false;
        }
    
        return itemDictionary.TryGetValue(id, out item);
    }
    
}
