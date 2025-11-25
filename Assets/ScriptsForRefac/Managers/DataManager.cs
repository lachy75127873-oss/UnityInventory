using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager 
{
    public void Init()
    {
        Debug.Log("데이터 매니저 초기화");
    }

    public void SaveData(PlayerData data)
    {
        string json = JsonUtility.ToJson(data);
        string filePath = Application.persistentDataPath + "/playerData.json";
        File.WriteAllText(filePath, json);
    }
    
}
