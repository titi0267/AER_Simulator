using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoint;
    public int test;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
