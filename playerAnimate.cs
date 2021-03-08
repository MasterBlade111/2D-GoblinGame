using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimate : MonoBehaviour
{
    private Animator playerAnimator;

    public string currentState;
    public string player_idle = "player_idle";
    public string player_jump = "player_jump";
    public string player_walk = "player_walk";

    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerVariable.isWalking && !playerVariable.isJumping)
        {
            PlayAnim(player_walk);
        }
        else if (!playerVariable.isWalking && !playerVariable.isJumping)
        {
            PlayAnim(player_idle);
        }
        else if (playerVariable.isJumping)
        {
            PlayAnim(player_jump);
        }
    }

    public void PlayAnim(string newState)
    {
        if (currentState == newState) return;
        playerAnimator.Play(newState);
        currentState = newState;
    }
}

