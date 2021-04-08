using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileBehaviour : MonoBehaviour
{
    public float Speed = 4;
    public bool Thrown;
    public Vector3 LaunchOffset;
    // Start is called before the first frame update
    public void Start()
    {
        if (Thrown) 
        {
            if (playerVariable.directionRight)
            {
                var direction = transform.right + Vector3.up;
                GetComponent<Rigidbody2D>().AddForce(direction * Speed, ForceMode2D.Impulse);
            }
            else if (playerVariable.directionRight == false)
            {
                var direction = -transform.right + Vector3.up;
                GetComponent<Rigidbody2D>().AddForce(direction * Speed, ForceMode2D.Impulse);
            }
            
            

        }
        transform.Translate(LaunchOffset);
        Destroy(gameObject, 6);
    }

    // Update is called once per frame
   private void Update()
    {
        //changing directions
        

        if (!Thrown) 
        {
            transform.position += -transform.right * Speed * Time.deltaTime;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
