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
        if (theme.text=="LGBT")
        {
            Gallop(3.9f);
            return;
        }
        Gallop(4f);
    }
    void Gallop(float legStr)
    {
        speed = Random.Range(1,10)*legStr;
        transform.Translate(0, 0, speed*Time.deltaTime);
    }
}
