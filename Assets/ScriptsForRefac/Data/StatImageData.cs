using System.Collections.Generic;
using UnityEngine;

//스텟 아이콘 저장용
[CreateAssetMenu(fileName = "StatImages")]
public class StatImageData :ScriptableObject
{
    [SerializeField] private List<StatImageInfo> list = new List<StatImageInfo>();

    private Dictionary<string, Sprite> iconImagess;

    public Sprite GetIcon(string iconName)
    {
        if (iconImagess == null)
        {
            iconImagess = new Dictionary<string, Sprite>();
            foreach (var kvp in list)
            {
                 iconImagess.Add(kvp.statName, kvp.statIcon);
            }
        }
        
        return iconImagess.TryGetValue(iconName, out Sprite sprite) ? sprite : null;
    }
}

[System.Serializable]
public class StatImageInfo
{
    public string statName;
    public Sprite statIcon;
}
