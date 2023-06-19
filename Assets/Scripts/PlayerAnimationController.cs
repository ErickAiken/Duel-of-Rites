using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{

    Animator animator;
    PlayerMovement playerMovement;
    JumpControl jumpControl;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        if (!animator)
            Debug.Log("ANIMATOR NOT FOUND");
        playerMovement = GetComponent<PlayerMovement>();
        if (!playerMovement)
            Debug.Log("PLAYER MOVEMENT COMPONENT NOT FOUND");
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunningForward", false);
        animator.SetBool("isRunningBackward", false);
    
        if(Input.GetKey("w") || playerMovement.autoRun)
        {
            if(playerMovement.IsGrounded())
            {
                animator.SetBool("isRunningForward", true);
                animator.SetBool("isRunningBackward", false);
            }
        }
        if(Input.GetMouseButton(0) && Input.GetMouseButton(1)){
            if(playerMovement.IsGrounded())
            {
                animator.SetBool("isRunningForward", true);
                animator.SetBool("isRunningBackward", false);
            }
        }
        if(Input.GetKey("s"))
        {
            if(playerMovement.IsGrounded())
            {
                animator.SetBool("isRunningForward", false);
                animator.SetBool("isRunningBackward", true);
            }
        }

        if(Input.GetKey(KeyCode.Space) && !playerMovement.IsGrounded()){
            animator.SetBool("isJumping", true);
        }
        else if(playerMovement.IsGrounded())
        {
            animator.SetBool("isJumping", false);
        }
        
    }
}
