using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    private int highScore = 0;
    public Text highScoreText;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreUI();
    }

    [ContextMenu("Dodaj punkt")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();

        
    }

    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if (highScore < playerScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
            UpdateHighScoreUI();
        }
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    private void UpdateHighScoreUI()
    {
        if(highScoreText != null)
        {
            highScoreText.text = highScore.ToString();
        }
    }

    [ContextMenu("Resetuj Rekord")]
    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScore = 0;
        UpdateHighScoreUI();
        Debug.Log("Rekord zresetowany!");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
