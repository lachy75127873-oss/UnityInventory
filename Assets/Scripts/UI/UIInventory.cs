using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
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
        UIManager.Instance.ToggleInventoryUI();
    }
}
