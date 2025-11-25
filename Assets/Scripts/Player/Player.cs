using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Dictionary<string, int> PlayerStats;
    
    private void Awake()
    {
        GameManager.Instance.player = this;
        Debug.Log("플레이어 등록");
        
        PlayerStats = new Dictionary<string, int>();
        
        Initialize();
    }

    private void Start()
    {
        Debug.Log(Name + Rank + Description);
    }

    private void Initialize()
    {
        Name =  "CDW";
        Rank = "Slave";
        Description = "He is Slave";
        Level = 1;
        Exp = 10;
        Gold = 1000;
        
        HP = 100;
        MP = 100;
        Speed = 10;
        Atk = 5;
        Def = 5;
        
        PlayerStats.Add("Hp", HP);
        PlayerStats.Add("Mp", MP);
        PlayerStats.Add("Atk", Atk);
        PlayerStats.Add("Def", Def);
        PlayerStats.Add("Speed", Speed);
    }
    
    
    
}
