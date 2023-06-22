using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationManager : MonoBehaviour
{

    public enum AnimationState
    {
        idle, 
        runningForward,
        runningBackward,
        jumping,
        casting,
        melee,
    }

    public AnimationState animationState;
    public GameObject gameManager;
    
    private GameDataManager gameData;
    private PlayerData playerData;
    private Animator animator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerData = GetComponent<PlayerData>();
        gameData = gameManager.GetComponent<GameDataManager>();
        animator = GetComponentInChildren<Animator>();
        animationState = AnimationState.idle;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunningForward", false);
        animator.SetBool("isRunningBackward", false);
        animator.SetBool("isJumping", false);
    }

    public void UpdateAnimationState(AnimationState state)
    {
        switch(state)
        {
            case AnimationState.idle:
                idle();
                break;
            case AnimationState.runningForward:
                runningForward();
                break;
            case AnimationState.runningBackward:
                runningBackward();
                break;
            case AnimationState.jumping:
                jumping();
                break;
            case AnimationState.casting:
                break;
            case AnimationState.melee:
                break;
            default:
                break;
        }
    }//UpdateAnimationState

    public void idle()
    {

    }

    public void runningForward()
    {
        animator.SetBool("isRunningForward", true);
        animator.SetBool("isRunningBackward", false);
    }

    public void runningBackward()
    {
        animator.SetBool("isRunningForward", false);
        animator.SetBool("isRunningBackward", true);
    }

    public void jumping()
    {
        animator.SetBool("isJumping", true);
    }


}
