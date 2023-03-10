using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public GameObject boss;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = (transform.right *speed)*-1;
        Destroy(gameObject, 1f);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        BossAttack boss = collider.GetComponent<BossAttack>();

        if (boss != null) {
            boss.setHealth(10);
            Destroy(gameObject);
        }
        if (collider.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            enemyComponent.TakeDamage(1f);
            Destroy(gameObject);
        }
        // Destroy(gameObject);
        Destroy(gameObject, 5f);
    }
}