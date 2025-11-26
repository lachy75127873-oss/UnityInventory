using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class DataManager 
{
    public void Init()
    {
        Debug.Log("데이터 매니저 초기화");
    }

    public void SaveData(PlayerData data)
    {
        string jsonData = JsonConvert.SerializeObject(data);
        string path = Path.Combine(Application.persistentDataPath, "PlayerData.json");

        try
        {
            File.WriteAllText(path, jsonData);
            Debug.Log("JsonData 저장 성공");
        }
        catch (Exception e)
        {
            Debug.Log("JsonData 저장 실패");
        }
    }

    public void LoadData()
    {
        string path = Path.Combine(Application.persistentDataPath, "PlayerData.json");

        if (File.Exists(path))
        {
            string loadedJsonData = File.ReadAllText(path);
            PlayerData loadedData = JsonConvert.DeserializeObject<PlayerData>(loadedJsonData);
            
            Debug.Log("플레이어 데이터 불러오기 성공");
        }
        else
        {
            Debug.Log("플레이어 데이터 불러오기 실패");
        }
        
    }
    
    
}
