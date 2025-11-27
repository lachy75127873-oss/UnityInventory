using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private Player player;

    public Player Player
    {
        get { return player; }
        set
        {
            player = value;
        }
    }

    protected override void Init()
    {
        Debug.Log("Initializing GameManager");
        
        InspectPlayer();
        
    }
    
    private void InspectPlayer()
    {
        if (player == null)
        {
            //플레이어 객체가 없을 경우
            //GameObject newPlayer = new GameObject("Player");
            GameObject newPlayerPrefab = Resources.Load<GameObject>("Prefabs/Player/Player"); 
            var playerObject = Instantiate(newPlayerPrefab);
            player = playerObject.AddComponent<Player>();
            Debug.Log("플레이어 생성완료");
        }
        else
        {
            Debug.Log("플레이어 생성완료");
        }
        
    }
    
    //종료 시 데이터 저장
    #if UNITY_EDITOR
    private void OnApplicationQuit()
    {
        ManagerRoot.Instance.dataManager.SavePlayerData(player.PlayerData);
        Debug.Log("저장 완료");
    }
    #endif
}
