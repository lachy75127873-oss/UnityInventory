using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : Singleton<ItemDataBase>
{
    [SerializeField] private List<ItemData> items;
    
    private Dictionary<int, ItemData> itemDictionary;

    public void Init()
    {
        Debug.Log("데이터 베이스 초기화중");
        itemDictionary = new Dictionary<int, ItemData>();
        foreach (var itemData in items)
        {
            itemDictionary.Add(itemData.idx, itemData);
            Debug.Log(itemData.name);
        }
    }

    public ItemData GetItem(int id)
    {
        return itemDictionary[id];
    }
    
}
