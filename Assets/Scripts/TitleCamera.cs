using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCamera : MonoBehaviour
{
    [SerializeField] Transform HorseTrans;

    // 回転軸
    [SerializeField] private Vector3 _axis = Vector3.down;

    // 円運動周期
    [SerializeField] private float _period;
    [SerializeField] private float angle;
    float timeElapsed;
    void Update()
    {
        timeElapsed += Time.deltaTime;
        angle = 360 / _period * Time.deltaTime;
        if (timeElapsed >= 5f)
        {
            if(transform.rotation.y <= 0.7f)
            {
                transform.RotateAround(
                    HorseTrans.position,
                    _axis,
                    angle
                );
            }
        }
        else if(timeElapsed >= 15f)
        {

        }
    }
}
