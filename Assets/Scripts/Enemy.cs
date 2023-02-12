using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 3f;
    private float collisionTimer;
    private float maxTimer;

    void Start()
    {
        health = maxHealth;
        maxTimer = 2f;
        collisionTimer = maxTimer;
    }

    public void TakeDamage(float damageTaken)
    {
        health -= damageTaken;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D collider)
    {
        if (collider.collider.name == "Player") {
            print("Collision player");
            PlayerHealth player = collider.collider.GetComponent<PlayerHealth>();

            if (player != null && collisionTimer <= 0) {
                player.damage(10);
                collisionTimer = maxTimer;
            }
        }
        collisionTimer -= Time.deltaTime;
    }
}
