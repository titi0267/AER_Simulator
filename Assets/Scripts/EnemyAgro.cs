using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{
    public GameObject player;
    Transform target;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // distance to player
        float distToPlayer = Vector2.Distance(transform.position, target.position);

        if (distToPlayer < agroRange)
        {
            // chase player
            ChasePlayer();

        }
        else
        {
            // stop chasing player
            StopChasingPlayer();
        }
    }

    void ChasePlayer()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        if (transform.position.x < target.position.x)
        {
            // enemy is to the left side of the player, so move right
            rb2d.velocity = new Vector2(moveSpeed, 0);
            spriteRenderer.flipX = false;
        }
        else if (transform.position.x > target.position.x)
        {
            // enemy is to the right side of the player, so move left
            rb2d.velocity = new Vector2(-moveSpeed, 0);
            spriteRenderer.flipX = true;
        }

    }

    void StopChasingPlayer()
    {
        rb2d.velocity = new Vector2(0, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision(ENTER) : mob hit player");
        // player takes 50 dmg because of mob Collision
        // damage(50);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision(EXIT) : mob hit player");
        // player takes 50 dmg because of mob Collision
        // damage(50);
    }
}
