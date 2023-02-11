using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletBoss;
    private float fireTimer;
    private float fireRate;

    // Start is called before the first frame update
    void Start()
    {
        fireRate = 0.5f;
        fireTimer=fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (fireTimer <= 0f) {
            Instantiate(bulletBoss, shootingPoint.position, shootingPoint.rotation);
            fireTimer = fireRate;
        } else {
            fireTimer -= Time.deltaTime;
        }
    }
}
