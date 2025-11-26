using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<Items> playerInventory;
    private PlayerData playerData;

    private void Awake()
    {
        SetPlayerData();
    }
    
    
    private void SetPlayerData()
    {
        Debug.Log("플레이어 데이터 세팅");

        var loadedData = ManagerRoot.Instance.dataManager.LoaPlayerData();
        if (loadedData != null)
        {
            //해당 데이터를 player에게 주입
            playerData = loadedData;
            Debug.Log(playerData.name+"/"+playerData.rank+ "/"+playerData.description + "/"+playerData.level + "/"+playerData.exp + "/"+playerData.gold);
        }
        else
        {
            //플레이어 초기값으로 세팅해라
            SetFirstPlayer();
            Debug.Log(playerData.name+"/"+playerData.rank+ "/"+playerData.description + "/"+playerData.level + "/"+playerData.exp + "/"+playerData.gold);

        }
        
    }

    private void SetFirstPlayer()
    {
        PlayerData pd = new PlayerData("First", "one", "He is First", 1, 1, 1);
        playerData = pd;
    }
}
