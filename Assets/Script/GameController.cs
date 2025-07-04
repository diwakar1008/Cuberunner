using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject tapToStart;
    public GameObject score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        score.SetActive(false);
        tapToStart.SetActive(true);
        GameOverPanel.SetActive(false);
        PauseGame();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            StartGame();
            score.SetActive(true);
        }
    }
    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        score.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void QuitMethod()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        tapToStart.SetActive(false);
        Time.timeScale = 1f;
    }
}
