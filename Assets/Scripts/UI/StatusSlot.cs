using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusSlot : MonoBehaviour
{
    [SerializeField] private StatImageData _statImageData;
    
    [SerializeField] private TextMeshProUGUI nameTxt;
    [SerializeField] private TextMeshProUGUI valueTxt;
    [SerializeField] private Image icon;

    public Image statusIcon;
    public string statusName;
    public int statusValue;


    public void SetStatInfo()
    {
        nameTxt.text = statusName;
        valueTxt.text = statusValue.ToString();
        icon.sprite = _statImageData.GetIcon(statusName);
    }
    
}
