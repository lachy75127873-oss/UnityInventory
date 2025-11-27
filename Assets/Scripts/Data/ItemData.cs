using UnityEngine;

[CreateAssetMenu(fileName = "NewItemData",  menuName = "Item/BaseItemData",  order = 1)]
public class ItemData : ScriptableObject
{
    public string name;
    public ItemType itemType;
    public string description;
    public int idx;
    public int value;
    public Sprite icon;
}

public enum ItemType 
{
    Atk,
    Def,
    Speed,
    Critical
}

