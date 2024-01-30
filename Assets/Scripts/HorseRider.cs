using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HorseRider : MonoBehaviour
{
    float speed;
    string cheatTheme;
    [SerializeField] TMP_Text theme;
    [SerializeField] Animator horseAnim;
    private void Start() 
    {
        horseAnim.enabled = false;
        cheatTheme = GameDataManager.Instance.cheatTheme.text;
    }
    public void HorseAnimEnable()
    {
        horseAnim.enabled = true;
    }
    public void Run()
    {
        horseAnim.Play(horseAnim.GetCurrentAnimatorStateInfo(0).shortNameHash);
        if (Input.GetKey(KeyCode.S))
        {
            if (theme.text==cheatTheme)
            {
                Gallop(3*4.1f);
                return;
            }
            Gallop(3*4f);
            return;
        }
        if (theme.text==cheatTheme)
        {
            Gallop(4.1f);
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
