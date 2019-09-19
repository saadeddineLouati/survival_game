using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashMenu : MonoBehaviour {

    void Start()
    {
        StartCoroutine(SceneChange());
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(6.5f);
        SceneManager.LoadScene(4);
    }
}
