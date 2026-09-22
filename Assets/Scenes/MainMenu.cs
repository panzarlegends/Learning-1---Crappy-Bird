using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{ 
    [SerializeField] private string gameSceneName = "GameScene";

    public void PlayGame()
    {
        Time.timeScale = 1f;

        // Load game
        SceneManager.LoadScene(gameSceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Gra została zamknięta!");
    }
}