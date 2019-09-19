using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A01SceneStart : MonoBehaviour
{

    public GameObject fadeInImg;

    void Start()
    {
        StartCoroutine(SceneWorks());
    }


    IEnumerator SceneWorks()
    {
        yield return new WaitForSeconds(1.6f);
        fadeInImg.SetActive(false);
    }
}