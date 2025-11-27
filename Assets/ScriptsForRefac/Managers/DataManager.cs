using System;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class DataManager 
{
    public void Init()
    {
        Debug.Log("데이터 매니저 초기화");
    }

    #region 플레이어 데이터 로드/저장
    public void SavePlayerData(PlayerData data)
    {
        string jsonData = JsonConvert.SerializeObject(data);
        string path = Path.Combine(Application.persistentDataPath, "PlayerData.json");

        try
        {
            File.WriteAllText(path, jsonData);
            Debug.Log("플레이어 데이터: " + path);
            Debug.Log("플레이어 데이터 저장 성공");
        }
        catch (Exception e)
        {
            Debug.Log("플레이어 데이터 저장 실패");
        }
    }

    public PlayerData LoaPlayerData()
    {
        string path = Path.Combine(Application.persistentDataPath, "PlayerData.json");

        if (File.Exists(path))
        {
            string loadedJsonData = File.ReadAllText(path);
            PlayerData loadedData = JsonConvert.DeserializeObject<PlayerData>(loadedJsonData);
            
            Debug.Log("플레이어 데이터 불러오기 성공");
            return loadedData;
        }
        else
        {
            Debug.Log("플레이어 데이터 불러오기 실패");
            return null;
        }
    }


    #endregion

    #region 아이템 데이터 제이슨 로드 대비

    public void SaveItemData(ItemData data)
    {
        string jsonData = JsonConvert.SerializeObject(data);
        string path = Path.Combine(Application.persistentDataPath, "ItemData.json");

        try
        {
            File.WriteAllText(path, jsonData);
            Debug.Log("저장 경로: " + path);
            Debug.Log("아이템 데이터 저장 성공");
        }
        catch (Exception e)
        {
            Debug.Log("아이템 데이터 저장 실패");
        }
    }

    public ItemData LoadItemData()
    {
        string path = Path.Combine(Application.persistentDataPath, "ItemData.json");

        if (File.Exists(path))
        {
            string loadedJsonData = File.ReadAllText(path);
            ItemData loadedData = JsonConvert.DeserializeObject<ItemData>(loadedJsonData);
            
            Debug.Log("아이템 데이터 불러오기 성공");
            return loadedData;
        }
        else
        {
            Debug.Log("아이템 데이터 불러오기 실패");
            return null;
        }
        
    }
    

    #endregion
    
    
    
    
}
