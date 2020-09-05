using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bird : MonoBehaviour
{
    public float moveSpeed;
    public float flapHeight;
    public GameObject PipeUp;
    public GameObject PipeDown;
    public Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);


        if (Input.GetMouseButtonDown(0))
        {

            rb2d.velocity = new Vector2(rb2d.velocity.x, flapHeight);
        }
        if (transform.position.y > 18 || transform.position.y < -19)
        {
            Death();
        }
    }
    public void Death()
    {
        rb2d.velocity = Vector3.zero;
        transform.position = new Vector2(0, 0);
    }
}
