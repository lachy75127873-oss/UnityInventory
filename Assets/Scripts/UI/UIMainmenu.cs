using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainmenu : MonoBehaviour
{
    [Header("Main Menu")]
    
    [Header("Buttons")]
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;
    [SerializeField] private Button returnBtn;
    
    [Header("Basic Info Text")]
    [SerializeField] private TextMeshProUGUI nameTxt;
    [SerializeField] private TextMeshProUGUI rankTxt;
    [SerializeField] private TextMeshProUGUI descriptionTxt;
    [SerializeField] private TextMeshProUGUI levelTxt;
    [SerializeField] private TextMeshProUGUI expTxt;
    [SerializeField] private TextMeshProUGUI goldTxt;
    
    private bool _onStatus;
    private bool _onInventory;
    private UIManager uiM;

    public void ReadyMainMenu()
    {
        Init();
        Debug.Log("UIMainMenu Init");
    }

    //메인메뉴 초기화
    private void Init()
    {
        if (statusButton == null) Debug.Log("UIMainMenu statusButton is null");
        if (inventoryButton == null) Debug.Log("UIMainMenu inventoryButton is null");
        
        Debug.Log("UI에 플레이어 등록");

        uiM = UIManager.Instance;
        
        statusButton.onClick.AddListener(uiM.ToggleStatusInfo);
        inventoryButton.onClick.AddListener(uiM.ToggleInventoryInfo);
        returnBtn.onClick.AddListener(uiM.ReturnToMainMenu);
        
        statusButton.gameObject.SetActive(true);
        inventoryButton.gameObject.SetActive(true);
        returnBtn.gameObject.SetActive(false);
        
       ShowBasicInfo();
    }

    //메인메뉴 기본 정보
    private void ShowBasicInfo()
    {
        var playerData =  GameManager.Instance.Player.PlayerData;
        
        nameTxt.text = playerData.name;
        rankTxt.text = playerData.rank;
        descriptionTxt.text = playerData.description;
        levelTxt.text = playerData.level.ToString();
        expTxt.text = playerData.exp.ToString();
        goldTxt.text = playerData.gold.ToString();
    }

    //버튼 전환
    public void ToggleBtns()
    {
        var isOn = uiM.onStatus || uiM.onInventory;
        returnBtn.gameObject.SetActive(isOn);
        
        statusButton.gameObject.SetActive(!isOn);
        inventoryButton.gameObject.SetActive(!isOn);
    }
    
    
}
