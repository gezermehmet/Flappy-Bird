using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void VolumeOn()
    {
        AudioListener.volume = 1.0f;
    }

    public void VolumeOff()
    {
        AudioListener.volume = 0.0f;
    }

    public void GoToGithub()
    {
        Application.OpenURL("https://github.com/gezermehmet");
    }
}
