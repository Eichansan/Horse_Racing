using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class TitleManager : MonoBehaviour
{
    [SerializeField] TitleSEManager titleSEManager;
    [SerializeField] GameObject startButton;
    [SerializeField] Button plusButton;
    [SerializeField] Button minusButton;
    [SerializeField] Button decideButton;
    [SerializeField] GameObject Canvas;
    [SerializeField] TMP_InputField inputFieldPrefab;
    [SerializeField] TMP_InputField cheatTheme;
    List<TMP_InputField> theme = new List<TMP_InputField>();  
    int themeMinSize = 1;
    int themeMaxSize = 18;
    private void Start() 
    {
        startButton.SetActive(true);   
    }
    public void OnStartButton()
    {
        titleSEManager.OnStartButton();
        startButton.SetActive(false);
        plusButton.gameObject.SetActive(true);
        minusButton.gameObject.SetActive(true);
        decideButton.gameObject.SetActive(true);
        minusButton.interactable = false;
        InputFieldCreate();
    }
    public void OnPlusButton()
    {
        titleSEManager.OnPlusButton();
        InputFieldCreate();
    }
    public void OnMinusButton()
    {
        titleSEManager.OnMinusButton();
        Destroy(theme.Last().gameObject);
        theme.Remove(theme.Last());
        if (theme.Count == themeMinSize) minusButton.interactable = false;
        if (theme.Count < themeMaxSize) plusButton.interactable = true;
    }
    public void OnDecideButton()
    {
        titleSEManager.OnDecideButton();
        for(int i=0; i<theme.Count; i++)GameDataManager.Instance.themeList.Add(theme[i]);
        GameDataManager.Instance.cheatTheme = cheatTheme;
        SceneManager.LoadScene("Game");
    }

    void InputFieldCreate()
    {
        theme.Add(Instantiate(inputFieldPrefab));
        theme.Last().gameObject.transform.SetParent(Canvas.transform,false);
        if (theme.Count < 10)
        {
            theme.Last().gameObject.transform.Translate(0, -60f*(theme.Count-1)*Screen.height/576, 0);
        }
        else
        {
            theme.Last().gameObject.transform.Translate(560f*Screen.width/1024, -60f*(theme.Count-10)*Screen.height/576, 0);
        }
        if (theme.Count > themeMinSize) minusButton.interactable = true;
        if (theme.Count == themeMaxSize) plusButton.interactable = false;
    }
}
