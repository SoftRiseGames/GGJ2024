using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Load the game scene
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        // Quit the application (works in a standalone build)
        Application.Quit();
    }
}
