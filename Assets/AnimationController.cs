using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
    
        if(Input.GetKey("a") || Input.GetKey("w") || Input.GetKey("d"))
        {
            animator.SetBool("isRunningForward", true);
            animator.SetBool("isRunningBackward", false);
        }else if(Input.GetKey("s"))
        {
            animator.SetBool("isRunningForward", false);
            animator.SetBool("isRunningBackward", true);
        }
    }
}
