using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private Player player;

    private void Start()
    {
        player= GetComponent<Player>();
        player = GameManager.Instance.player;
        Debug.Log("플레이어 등록");
    }
}
