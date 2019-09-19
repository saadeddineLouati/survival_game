using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthMonitor : MonoBehaviour {

    public static int healthPoints = 300;
    public int internalHealth;
    public GameObject healthDisplay;
    public GameObject healthBar;
 

    void Update () {
        internalHealth = healthPoints;
        //healthDisplay.GetComponent<Text>().text = "" + healthPoints;
        healthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(healthPoints, 30);
        if(healthPoints <= 0)
        {
            SceneManager.LoadScene(3);
        }

    }
}
