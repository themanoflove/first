using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    // move och jump har kraft mellan 0,20
    [Range(0, 20f)]
    public float moveSpeed;
    public float jumpHeight;
    //En groundcheck
    public GrounfCheck groundcheck;
    //En rigidbody
    //privat kan endast ändras i unity och inte i ett script
    private Rigidbody2D rbody;
    public int superjump = 100;
    public bool isLeft = true;
    public float movespeed = 0f;
    





    // Use this for initialization
    //Händer när scriptets startar, 
    void Start()
    {
        //Rbody gör en copoment, och den kör på sig själv. Den gör så att rbody lägger sig på spelaren
        rbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    //Det händer 1 gång varje frame
    void Update()
    {

        //Sätter voelocity till en ny vector2, sen gångar horizontal med move speed. 
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

        //Om man trycker på space och variabeln groundCheck är mer än 0 så kan man hoppa
        if (Input.GetKeyDown(KeyCode.Space) && groundcheck.touches > 0)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
        }
        if (Input.GetKey(KeyCode.D))
            {

            Move1();

        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SuperJump")
        {
            rbody.velocity = new Vector2(rbody.velocity.x, superjump);
        }
    }
    void Move1(bool flip = true)
    {
        //= lika med == jämför
        if (flip == true)
        {
            isLeft = !isLeft;
        }
        //// Om ileft är sann ändrast scalan till 1,1,1, detta gör så den går höger
        //if (isLeft == true)
        //{
        //    rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
        //    transform.localScale = new Vector3(1, 1, 1);
        //}
        //else
        ////Om den inte är det ändrast x värdet till -, det gör så att enemy går vänster
        //{
        //    rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
        //    transform.localScale = new Vector3(-1, 1, 1);
        //}
    }
}
