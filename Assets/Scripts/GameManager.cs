using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text resultText;
    public Button retryButton;

    public bool hasStarted = false; // スタートしたかどうかのフラグ

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        resultText.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);
        retryButton.onClick.AddListener(RestartGame);
    }

    public void StartGame()
    {
        hasStarted = true;
        Debug.Log("スタート！");
    }

    public void GameOver()
    {
        ShowResult("壁に当たった！");
    }

    public void GameClear()
    {
        ShowResult("クリア！");
    }

    void ShowResult(string message)
    {
        resultText.text = message;
        resultText.gameObject.SetActive(true);
        retryButton.gameObject.SetActive(true);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
