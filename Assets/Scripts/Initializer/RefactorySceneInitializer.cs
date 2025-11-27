using UnityEngine;

public class RefactorySceneInitializer : MonoBehaviour, Initializer
{
    public void Initialize()
    {
        Debug.Log("RefactorySceneInitializer 가동");

        //초기화 순서 지정
        AboutGameManager();
        AboutUIManager();
    }

    #region 매니저 초기화

    private void AboutGameManager()
    {
        var gameManager = GameManager.Instance;
        if (gameManager == null)
        {
            GameObject newGameManager = new GameObject("GameManager");
            gameManager = newGameManager.AddComponent<GameManager>();
            Debug.Log("게임매니저 초기화 완료");
        }
        else
        {
            Debug.Log("게임매니저 초기화 완료");

        }
    }

    private void AboutUIManager()
    {
        var uiManager = UIManager.Instance;
        if (uiManager == null)
        {
            GameObject newUIManager = new GameObject("UIManager");
            uiManager = newUIManager.AddComponent<UIManager>();
            Debug.Log("UI매니저 초기화 완료");
        }
        else
        {
            Debug.Log("UI매니저 초기화 완료");
        }
    }
    

    #endregion
    
}
