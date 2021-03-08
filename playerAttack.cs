using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (!playerVariable.isJumping)
            {
                playerVariable.isAttacking[0] = true;
            }
        }
    }
}
