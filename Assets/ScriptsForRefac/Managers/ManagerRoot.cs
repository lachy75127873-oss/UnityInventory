using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerRoot :Singleton<ManagerRoot>
{
    protected override void Init()
    {
        Debug.Log("Initializing ManagerRoot");

        SceneManager.sceneLoaded += InitializeScene;

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
