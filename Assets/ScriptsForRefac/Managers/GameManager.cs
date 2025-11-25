using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Player player;

    protected override void Init()
    {
        Debug.Log("Initializing GameManager");
    }
    
}
