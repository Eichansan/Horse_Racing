using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLineRenderer : MonoBehaviour
{
    LineRenderer linerend;

    void Start()
    {
        linerend = GetComponent<LineRenderer>();

        Vector3 pos1 = new Vector3(500f, 1.3f, 400f);
        Vector3 pos2 = new Vector3(700f, 1.3f, 400f);

        // 線を引く場所を指定する
        linerend.SetPosition(0, pos1);
        linerend.SetPosition(1, pos2);
    }
}
