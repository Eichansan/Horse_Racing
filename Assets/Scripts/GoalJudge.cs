using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalJudge : MonoBehaviour
{
    [SerializeField] GameSEManager gameSEManager;
    [SerializeField] GameObject resultObjs;
    [SerializeField] TMP_Text resultText;
    bool firstGoaled;
    private void Start() 
    {
        resultObjs.SetActive(false);   
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "horse")
        {
            if (!firstGoaled)
            {
                StartCoroutine(gameSEManager.GoalSE());
                firstGoaled = true;
                resultText.text = collider.gameObject.GetComponent<Horse>().GetHorseText();
                resultObjs.SetActive(true);
            }
        }
    }

}
