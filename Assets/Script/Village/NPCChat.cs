using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCChat : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCursor;
    public GameObject subText;
    public GameObject subBox;
    public GameObject mainBlocker;
    public GameObject blockText;


    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionDisplay.SetActive(true);
            ActionText.GetComponent<Text>().text = "Talk";
            ActionText.SetActive(true);
            ExtraCursor.SetActive(true);
        }
        else
        {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCursor.SetActive(false);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                if (DialogState.stateAxeTake == false) {
                    subBox.SetActive(true);
                    subText.GetComponent<Text>().text = "Please come back to me when you have a weapon.";
                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionDisplay.SetActive(false);
                    ActionText.SetActive(false);
                    ExtraCursor.SetActive(false);
                    StartCoroutine(ResetChat());
                }
            if (DialogState.stateAxeTake == true) //we got the axe
                {
                    subBox.SetActive(true);
                    subText.GetComponent<Text>().text = "I see you have a weapon. I have a small favor to ask to you. Please can you eliminate the monster outside this village?";
                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionDisplay.SetActive(false);
                    ActionText.SetActive(false);
                    ExtraCursor.SetActive(false);
                    mainBlocker.SetActive(false);
                    blockText.SetActive(false);
                    StartCoroutine(ResetChat());
                }
            }
        }
    }

    void OnMouseExit() //this is when mouse moves away
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCursor.SetActive(false);
    }

    IEnumerator ResetChat()
    {
        yield return new WaitForSeconds(2.5f);
        subBox.SetActive(false);
        subText.GetComponent<Text>().text = "";
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
