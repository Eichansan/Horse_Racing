using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Course : MonoBehaviour
{
    [SerializeField] GameObject leftCourse,rightCourse;
    void Start()
    {
        int courseLength = 48;
        for (int i=1; i<100; i++)
        {
            Instantiate(leftCourse, new Vector3( 582f, 1.5f, 50f+courseLength*i), Quaternion.identity);
            Instantiate(rightCourse, new Vector3( 618f, 1.5f, 50f+courseLength*i), Quaternion.identity);
        }
    }

}
