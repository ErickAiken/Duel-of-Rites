using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    Animator animator;
    public GameObject player;
    PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); 
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunningForward", false);
        animator.SetBool("isRunningBackward", false);
    
        if(Input.GetKey("w") || playerMovement.autoRun)
        {
            animator.SetBool("isRunningForward", true);
            animator.SetBool("isRunningBackward", false);
        }
        if(Input.GetKey("s"))
        {
            animator.SetBool("isRunningForward", false);
            animator.SetBool("isRunningBackward", true);
        }
    }
}
