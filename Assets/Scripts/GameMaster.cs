using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    [SerializeField] GameSEManager gameSEManager;
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject horsePrefab;
    List<GameObject> horse = new List<GameObject>();
    List<HorseRider> horseRider = new List<HorseRider>();
    bool isStarting=false;

    private void Awake()
    {
        int horseCount = GameDataManager.Instance.themeList.Count;
        for(int i=0; i<horseCount; i++)
        {
            float distance = 1.4f;
            float transPos = distance*((i+1)/2)*Mathf.Pow(-1,i);
            horse.Add(Instantiate(horsePrefab));
            horse[i].transform.Translate(transPos, 0, 0);
            horse[i].GetComponent<Horse>().Init(GameDataManager.Instance.themeList[i].text);
            horseRider.Add(horse[i].GetComponent<HorseRider>());
        }
        startButton.SetActive(true);
    }
    public void OnStart()
    {
        gameSEManager.OnStartButton();
        isStarting = true;
        for(int i=0; i<horse.Count; i++)horseRider[i].HorseAnimEnable();
        startButton.SetActive(false);
    }
    private void Update() 
    {
        if(!isStarting)
        {
            return;
        }
        else
        {
            for(int i=0; i<horse.Count; i++)horseRider[i].Run();
        }
    }
    public void ToTitle()
    {
        GameDataManager.Instance.themeList.Clear();
        SceneManager.LoadScene("Title");
    }

}
