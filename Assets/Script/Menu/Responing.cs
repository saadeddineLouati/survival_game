using UnityEngine;
using UnityEngine.SceneManagement;

public class Responing : MonoBehaviour {

	
	void Start () {

        HealthMonitor.healthPoints = 300;
        SceneManager.LoadScene(0);
	}
	
}
