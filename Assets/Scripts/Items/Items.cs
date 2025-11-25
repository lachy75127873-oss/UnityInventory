using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public string Name { get;protected set; }
    public string EffectType { get;protected set; }
    public int EffectValue { get;protected set; }
}

public class FirstItem:Items
{
    private void Awake()
    {
        Init();
    }
    private void Init()
    {
        Name = "First";
        EffectType = "Hp";
        EffectValue = 5;
    }
}

public class SecondItem
{
    
}

public class ThirdItem
{
    
}