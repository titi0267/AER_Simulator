using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomana : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioSource audioSource;
    public GameObject Player;
    private bool Isplayed = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = playlist[1];
        audioSource.loop = true;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x >= -15 && !Isplayed) {
            audioSource.Stop();
            audioSource.clip = playlist[2];
            audioSource.loop = true;
            audioSource.Play();
            Isplayed = true;
        }
    }
}
