using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{
    private Rigidbody2D rb;

    public float jumpSpeed, xOffset, yOffset, xSize, ySize;
    public bool onFloor;
    public LayerMask floorMask;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        onFloor = Physics2D.OverlapBox(new Vector2(transform.position.x + xOffset, transform.position.y + yOffset), new Vector2(xSize, ySize), 0f, floorMask);

        if (Input.GetKeyDown(KeyCode.UpArrow) && onFloor)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            playerVariable.isJumping = true;
        }
        playerVariable.isJumping = !onFloor;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(new Vector2(transform.position.x + xOffset, transform.position.y + yOffset), new Vector2(xSize, ySize));
    }
}
