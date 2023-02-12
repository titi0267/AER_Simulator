using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomana2 : MonoBehaviour
{

    public AudioClip[] playlist;
    public AudioSource audioSource;

    void Start()
    {
        audioSource.clip = playlist[0];
        audioSource.loop = true;
        audioSource.Play();
    }

    void Update()
    {

    }

    public void GoToHub()
    {
        audioSource.Stop();
    }
}
