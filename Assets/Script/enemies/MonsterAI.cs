using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour {

    public GameObject theMonster;
    public bool isAttacking = false;

    void OnTriggerEnter(Collider other)
    {
        if (isAttacking == false)
        {
            isAttacking = true;
            this.GetComponent<MeshCollider>().enabled = false;
            theMonster.GetComponent<Animator>().Play("Attack");
            theMonster.GetComponent<NavAI>().enabled = false;
            theMonster.GetComponent<NavMeshAgent>().enabled = false;
            StartCoroutine(TakeHealth());
        }
    }

    void OnTriggerExit(Collider other)
    {
        theMonster.GetComponent<Animator>().Play("Walk");
        theMonster.GetComponent<NavAI>().enabled = true;
        theMonster.GetComponent<NavMeshAgent>().enabled = true;
        StopCoroutine(TakeHealth());
        this.GetComponent<MeshCollider>().enabled = true;
        isAttacking = false;
    }

    IEnumerator TakeHealth()
    {
        yield return new WaitForSeconds(1.1f);
        HealthMonitor.healthPoints -= 50;
        yield return new WaitForSeconds(1f);
        isAttacking = false;
        theMonster.GetComponent<Animator>().Play("Walk");
        theMonster.GetComponent<NavAI>().enabled = true;
        theMonster.GetComponent<NavMeshAgent>().enabled = true;
        this.GetComponent<MeshCollider>().enabled = true;
    }

}
