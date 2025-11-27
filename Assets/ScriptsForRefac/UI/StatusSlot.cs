using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusSlot : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameTxt;
    [SerializeField] private TextMeshProUGUI valueTxt;
    [SerializeField] private RawImage icon;

    public RawImage statusIcon;
    public string statusName;
    public int statusValue;


    public void SetStatInfo()
    {
        nameTxt.text = statusName;
        valueTxt.text = statusValue.ToString();
        //icon.texture = statusIcon.texture;
    }
    
}
