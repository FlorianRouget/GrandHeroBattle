using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public string GameScene;

    public void GoToGame()
    {
        if (GameScene == null)
        {
            Debug.LogError("The GameScene parameter is not set !");
            return;
        }

        SceneManager.LoadScene(GameScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
