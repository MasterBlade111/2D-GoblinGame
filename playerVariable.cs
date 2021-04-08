using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerVariable : MonoBehaviour
{
    public static bool isWalking, isJumping, isDodging;
    public static bool[] isAttacking = new bool[2];
    public static bool directionRight;
}
