using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleHorse : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, 0, 10f*Time.deltaTime);
    }
}
