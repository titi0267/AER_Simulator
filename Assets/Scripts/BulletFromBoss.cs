using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFromBoss : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = (transform.right *speed)*-1;
        Destroy(gameObject, 4f);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        PlayerHealth player = collider.GetComponent<PlayerHealth>();

        if (player != null) {
            player.damage(10);
            Destroy(gameObject);
        }
    }
}
