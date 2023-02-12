using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject[] enemy;
    public Transform[] spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        int randEnemy;
        int randTypeEnemy;

        for (int i = 0; i <= 23; i++) {
            randEnemy = Random.Range(0,2);
            randTypeEnemy = Random.Range(0,2);
            if (randEnemy == 1) {
                Instantiate(enemy[randTypeEnemy], spawnPoint[i].position, spawnPoint[i].rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
