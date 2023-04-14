using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSEManager : MonoBehaviour
{
    [SerializeField] AudioClip decide;
    [SerializeField] AudioClip start;
    [SerializeField] AudioClip plus;
    [SerializeField] AudioClip minus;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnPlusButton()
    {
        audioSource.PlayOneShot(plus);
    }
    public void OnMinusButton()
    {
        audioSource.PlayOneShot(minus);
    }
    public void OnStartButton()
    {
        audioSource.PlayOneShot(start);
    }
    public void OnDecideButton()
    {
        audioSource.PlayOneShot(decide,0.5f);
    }
}
