using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameDataManager : MonoBehaviour
{
    public List<TMP_InputField> themeList = new List<TMP_InputField>();
    public TMP_InputField cheatTheme;
    public static GameDataManager Instance { get; set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
}
