using UnityEngine;
using UnityEngine.SceneManagement;

public class newnew : MonoBehaviour {

    public void RestartGameButton()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(4);
    }
}
