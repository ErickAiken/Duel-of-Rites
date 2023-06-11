using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    Animator animator;
    public GameObject player;
    PlayerMovement playerMovement;
    JumpControl jumpControl;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); 
        playerMovement = player.GetComponent<PlayerMovement>();
        jumpControl = GetComponent<JumpControl>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunningForward", false);
        animator.SetBool("isRunningBackward", false);
    
        if(Input.GetKey("w") || playerMovement.autoRun)
        {
            if(jumpControl.isGrounded){
                animator.SetBool("isRunningForward", true);
                animator.SetBool("isRunningBackward", false);
            }
        }
        if(Input.GetMouseButton(0) && Input.GetMouseButton(1)){
            if(jumpControl.isGrounded){
                animator.SetBool("isRunningForward", true);
                animator.SetBool("isRunningBackward", false);
            }
        }
        if(Input.GetKey("s"))
        {
            if(jumpControl.isGrounded){
                animator.SetBool("isRunningForward", false);
                animator.SetBool("isRunningBackward", true);
            }
        }

        if(Input.GetKey(KeyCode.Space) && !jumpControl.isGrounded){
            animator.SetBool("isJumping", true);
        }else if(jumpControl.isGrounded){
            animator.SetBool("isJumping", false);
        }
        
    }
}
