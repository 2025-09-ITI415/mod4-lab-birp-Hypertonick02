using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void ReplayGame()
    {
        // Reset score
        ScoreManager.instance.score = 0;

        // Load first level (replace with your actual scene name)
        SceneManager.LoadScene(0);
    }
}
