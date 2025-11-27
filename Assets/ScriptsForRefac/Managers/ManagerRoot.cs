using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerRoot :Singleton<ManagerRoot>
{
    [SerializeField] private ItemDataBase itemDataBase;
    public DataManager dataManager;
    
    protected override void Init()
    {
        Debug.Log("Initializing ManagerRoot");
        
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += InitializeScene;
        
        dataManager = new DataManager();
        dataManager.Init();
        itemDataBase.Init();
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= InitializeScene;
    }

    private void InitializeScene(Scene scene, LoadSceneMode mode)
    {
        IEnumerable<Initializer> initializers = FindObjectsOfType<MonoBehaviour>().OfType<Initializer>();

        foreach (var initializer in initializers)
        {
            initializer.Initialize();
        }
    }

}
