using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jump;
    private float _move;

    public Rigidbody2D rb;


    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(_move * speed, rb.velocity.y);
        if (_move > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
            //transform.localScale = new Vector3(-0.5, 0.5, 1);
        } else if (_move < 0) {
            transform.eulerAngles = new Vector3(0, 180, 0);
            //transform.localScale = new Vector3(0.5, 0.5, 1);
        }
        if(Input.GetButtonDown("Jump") && transform.position.y <= -0.38)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }

}
