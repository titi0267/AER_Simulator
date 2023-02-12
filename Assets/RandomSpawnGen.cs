using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnGen : MonoBehaviour
{
    public Transform[] spawnPoints;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        health--;
    }
}
