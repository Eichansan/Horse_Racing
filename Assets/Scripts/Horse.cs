using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Horse : MonoBehaviour
{
    [SerializeField] GameObject saddle;
    [SerializeField] TMP_Text themeText;
    [SerializeField] List<GameObject> horseParts = new List<GameObject>();
    [SerializeField] List<Material> horseMaterial = new List<Material>();
    [SerializeField] List<Material> saddleMaterial = new List<Material>();
    public void Init(string text)
    {
        int horseColorNum = Random.Range(0,horseMaterial.Count);
        int saddleColorNum =  Random.Range(0,saddleMaterial.Count);
        HorseMatDecide(horseColorNum, saddleColorNum);
        themeText.text = text;
    }
    void HorseMatDecide(int horseColorNum, int saddleColorNum)
    {
        for (int i=0; i < horseParts.Count; i++)horseParts[i].GetComponent<MeshRenderer>().material = horseMaterial[horseColorNum];
        saddle.GetComponent<MeshRenderer>().material = saddleMaterial[saddleColorNum];
    }
    public string GetHorseText()
    {
        return themeText.text;
    }

}
