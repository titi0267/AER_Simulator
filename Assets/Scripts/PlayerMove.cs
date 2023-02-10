using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jump;
    private float _move;
    private float _lastYPos;
    private bool _isGrounded;

    public Rigidbody2D rb;


    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _lastYPos = transform.position.y;
    }

    void Update()
    {
        _move = Input.GetAxis("Horizontal");
        _isGrounded = (_lastYPos == transform.position.y);
        _lastYPos = transform.position.y;
        rb.velocity = new Vector2(_move * speed, rb.velocity.y);
        if (_move < 0) {
            transform.localScale = new Vector3(-1, 1, 1);
        } else {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if(Input.GetButtonDown("Jump") && _isGrounded == true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }
}
