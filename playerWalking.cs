using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalking : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveInputH;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerVariable.isWalking);
        moveInputH = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveInputH * speed, rb.velocity.y);
        if (moveInputH != 0)
        {
            playerVariable.isWalking = true;
        }
        else
        {
            playerVariable.isWalking = false;
        }
        if (moveInputH > 0)
        {
            transform.localScale = new Vector2(1f, transform.localScale.y);
        }
        else if (moveInputH < 0)
        {
            transform.localScale = new Vector2(-1f, transform.localScale.y);
        }
    }
}
