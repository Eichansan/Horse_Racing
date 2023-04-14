using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CameraMove : MonoBehaviour
{
    List<GameObject> horses = new List<GameObject>(); 
    GameObject[] tmp_horses;
    int nowNum=0;
    private void Start() 
    {
        transform.position = new Vector3(0,5,-16);
        tmp_horses = GameObject.FindGameObjectsWithTag("horse");
        for (int i=0; i<tmp_horses.Length; i++) horses.Add(tmp_horses[i]);
        transform.SetParent(horses[nowNum].gameObject.transform,false);
        nowNum++;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            transform.SetParent(horses[nowNum].gameObject.transform,false);
            if (nowNum < horses.Count)nowNum++;
            if (nowNum == horses.Count)nowNum = 0;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.localPosition = new Vector3(0,5,-16);//ここに座標を持ってくる
            transform.rotation = Quaternion.Euler(20f, 0f, 0f);//回転もここに持ってくる
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localPosition = new Vector3(15,5,-2);//ここに座標を持ってくる
            transform.rotation = Quaternion.Euler(20f, -90f, 0f);//回転もここに持ってくる
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localPosition = new Vector3(-15,5,-2);//ここに座標を持ってくる
            transform.rotation = Quaternion.Euler(20f, 90f, 0f);//回転もここに持ってくる
        }
    }
}
