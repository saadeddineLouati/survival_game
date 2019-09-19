using UnityEngine;
//using UnityEngine.Component;
using UnityEngine.AI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Internal;


public class MonsterEnemy : MonoBehaviour
{

    public int enemyHealth = 10;
    public GameObject attackObj;

    private float timer = 0.0f;

    void DeductPoints(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

   

    void Update()
    {
        
        if (enemyHealth <= 0)
        {
            timer += Time.deltaTime;
            ///this.gameObject.SetActive(false);
            this.GetComponent<Animator>().Play("Death");
            
            this.GetComponent<NavAI>().enabled = false;
            this.GetComponent<NavMeshAgent>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            attackObj.SetActive(false);
            if( timer > 5)
                SceneManager.LoadScene(2);

        } 
    }
} 