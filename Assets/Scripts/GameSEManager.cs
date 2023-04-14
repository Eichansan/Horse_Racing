using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSEManager : MonoBehaviour
{
    [SerializeField] AudioClip pistol;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnStartButton()
    {
        audioSource.PlayOneShot(pistol);
    }
    public IEnumerator GoalSE()
    {
        audioSource.PlayOneShot(pistol);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(pistol);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(pistol);
    }
}
