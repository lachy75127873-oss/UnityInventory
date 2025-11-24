using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Button returnButton;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        returnButton.onClick.AddListener(ReturnMainMenu);
    }

    private void ReturnMainMenu()
    {
        UIManager.Instance.ToggleStatusUI();
    }
}
