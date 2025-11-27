using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerData PlayerData
    {
        get => playerData;
        set => playerData = value;
    }
    private PlayerData playerData;

    public PlayerCondition PlayerCondition
    {
        get => playerCondition;
        set => playerCondition = value;
    }
    private PlayerCondition playerCondition ;
    

    private Dictionary<int, int> playerInventory;

    private void Awake()
    {
        SetPlayerData();
    }

    #region 플레이어 초기화

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
        playerInventory = new Dictionary<int, int>();
        PlayerData pd = new PlayerData("First", "one", "He is First", 1, 1, 1, playerInventory);
        playerData = pd;
        
        SetPlayerInventory();
        SetBasicPlayerCondition();
    }

    #endregion
    
    private void SetPlayerInventory()
    {
        playerInventory.Add(ItemDataBase.Instance.GetItem(1001).idx,1);
        playerInventory.Add(ItemDataBase.Instance.GetItem(1002).idx,1);
        playerInventory.Add(ItemDataBase.Instance.GetItem(1003).idx,1);
        playerInventory.Add(ItemDataBase.Instance.GetItem(1004).idx,1);

        foreach (var kv in playerInventory)
        {
            Debug.Log(kv.Key+"/"+kv.Value);
        }
    }

    private void SetBasicPlayerCondition()
    {
        var pCd = new PlayerCondition();
        pCd.SetStat("Hp",100);
        pCd.SetStat("Mp",20);
        pCd.SetStat("Atk",15);
        pCd.SetStat("Def",10);
        playerCondition = pCd;
    }

    private void SetPlayerCondition()
    {
        /*
         * 기본 스탯에 
         * 인벤토리-장비 장착 상태에 따른 스탯 변화 반영 매서드
         */ 
    }
    
}


