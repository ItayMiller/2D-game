using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float walkSpeed = 10.0f;
    public bool facingRight = true;
    public double Xspeed;
    public double Yspeed;
    // Use this for initialization
    void Start()
    {
        Xspeed = 2;
        Yspeed = 1.5;
    }
  
    // Update is called once per frame
    void FixedUpdate()
    {
        if()
        /*float move = Input.GetAxis("Horizontal");
        if (move < 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(move * walkSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (move > 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(move * walkSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (move < 0 && facingRight)
        {
            Flip();
        }
        if (move > 0 && !facingRight)
        {
            Flip();
        }*/
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(Vector3.up * 180);
    }

}
