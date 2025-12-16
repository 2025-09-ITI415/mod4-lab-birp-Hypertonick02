using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Collectathon_Map");
    }

}
