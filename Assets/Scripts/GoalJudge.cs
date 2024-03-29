using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalJudge : MonoBehaviour
{
    [SerializeField] GameSEManager gameSEManager;
    [SerializeField] GameObject resultObjs;
    [SerializeField] GameObject titleButton;
    [SerializeField] GameObject instruction;
    public List<TMP_Text> resultText = new List<TMP_Text>();
    int rank = 0;
    bool firstGoaled;
    private void Start() 
    {
        resultObjs.SetActive(false);  
        titleButton.SetActive(false); 
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "horse")
        {
            if (!firstGoaled)
            {
                StartCoroutine(gameSEManager.GoalSE());
                firstGoaled = true;
                instruction.SetActive(false);
                resultObjs.SetActive(true);
                titleButton.SetActive(true);
            }
            resultText[rank].text = $"{rank+1}. " + collider.gameObject.GetComponent<Horse>().GetHorseText();
            rank++;
        }
    }

}
