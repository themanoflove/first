using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{

    public float movespeed = 2f;
    private Rigidbody2D rbody;
    public bool isLeft = true;



    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Move();
        }
    }
    void Move(bool flip = true)
    {
        if (flip == true)
        {
            isLeft = !isLeft;
        }
        if (isLeft == true)
        {
            rbody.velocity = new Vector2(-movespeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = new Vector2(movespeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleflipWall")
        {
            Move(true);
        }
    }
}
