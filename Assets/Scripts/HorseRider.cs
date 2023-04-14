using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HorseRider : MonoBehaviour
{
    float speed;
    [SerializeField] TMP_Text theme;
    public void Run()
    {
        if ( theme.text=="LGBT" )
        {
            speed = Random.Range(1,10)*3.8f;
            transform.Translate(0, 0, speed*Time.deltaTime);
        }
        else 
        {
            speed = Random.Range(1,10)*4f;
            transform.Translate(0, 0, speed*Time.deltaTime);
        }
    }
}
