using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalking : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveInputH,inputVertical;
    public float speed, xOffset, yOffset, xSize, ySize, distance;
    public bool isClimbing;
    public LayerMask ladderMask;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        // Walking code
       
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
            playerVariable.directionRight = true;
        }
        else if (moveInputH < 0)
        {
            transform.localScale = new Vector2(-1f, transform.localScale.y);
            playerVariable.directionRight = false;
        }



        //________________________________________________________________________________CLIMBING CODE_______________________________________________________________



        
        //Set detection ray for climbing

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, ladderMask);

        if (hitInfo.collider != null)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                isClimbing = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                isClimbing = false;
            }
            
        }

        //IF player is climbing, movement script

        if (isClimbing == true && hitInfo.collider != null)
        {
            //sets velocity to move upwards
            inputVertical = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, inputVertical * speed);
            rb.gravityScale = 0;

            
        }
        else
        {
            rb.gravityScale = 4;
        }
        
    }

    
}
