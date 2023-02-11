using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bullets;
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
            if (Keyboard.current.enterKey.wasPressedThisFrame && fireTimer <= 0f) {
            Instantiate(bullets, shootingPoint.position, shootingPoint.rotation);
            fireTimer = fireRate;
        } else {
            fireTimer -= Time.deltaTime;
        }

    }

}
