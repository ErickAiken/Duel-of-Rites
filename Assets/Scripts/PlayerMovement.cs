using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 5.0f;
    public bool autoRun = false;
    public float jumpHeight = 50f;

    public float distToGround;

    public bool isGrounded;

    private Vector3 movementPlane;
    private Vector3 characterDir;
    private PlayerData playerData;

    Rigidbody rb;
    Collider cldr;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (!rb)
            Debug.Log("Player rigid body component not found.");
        cldr = GetComponent<CapsuleCollider>();
        if (!cldr)
            Debug.Log("Player capsule collider not found.");
        animator = GetComponentInChildren<Animator>();
        if (!animator)
            Debug.Log("Player animator not found.");
        distToGround = cldr.bounds.extents.y;
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunningForward", false);
        animator.SetBool("isRunningBackward", false);
        animator.SetBool("isJumping", false);

        IsGrounded();
        movementPlane = Camera.main.transform.forward;
        characterDir = rb.transform.forward;
        movementPlane.y = 0.0f;

        if(Input.GetKey(KeyCode.W) || autoRun){
            if(Input.GetMouseButton(0)){
                rb.transform.position = rb.transform.position + characterDir * moveSpeed * Time.deltaTime;
            }else if(!autoRun){
                rb.transform.position = rb.transform.position + movementPlane * moveSpeed * Time.deltaTime;
            }else{
                rb.transform.position = rb.transform.position + characterDir * moveSpeed * Time.deltaTime;
            }
            if (isGrounded)
            {
                animator.SetBool("isRunningForward", true);
                animator.SetBool("isRunningBackward", false);
            }
        }

        if(Input.GetMouseButton(0) && Input.GetMouseButton(1)){
            if( !Input.GetKey(KeyCode.W) && !autoRun){
                rb.transform.position = rb.transform.position + movementPlane * moveSpeed * Time.deltaTime;
            }
            if (isGrounded)
            {
                animator.SetBool("isRunningForward", true);
                animator.SetBool("isRunningBackward", false);
            }
        }

        if(Input.GetKey(KeyCode.W)){
            autoRun = false;
        }

        if(Input.GetKey(KeyCode.BackQuote)){
            autoRun = true;
        }

        if(Input.GetKey(KeyCode.S)){
            if(Input.GetMouseButton(0)){
                rb.transform.position = rb.transform.position - characterDir * moveSpeed * Time.deltaTime;
            }else{
                rb.transform.position = rb.transform.position - movementPlane * moveSpeed * Time.deltaTime;
            }
            autoRun = false;
            if (isGrounded)
            {
                animator.SetBool("isRunningForward", false);
                animator.SetBool("isRunningBackward", true);
            }
        }

        if(Input.GetKey(KeyCode.D)){
            rb.transform.Rotate(Vector3.up * rotateSpeed * 15.0f * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A)){
            rb.transform.Rotate(-Vector3.up * rotateSpeed * 15.0f * Time.deltaTime);
        }

        // Strafe Right
        if (Input.GetMouseButton(1) && Input.GetKey(KeyCode.D)){
            Debug.Log("Strafe Right");
            if(Input.GetKey(KeyCode.W)){
                rb.transform.position = rb.transform.position + Quaternion.Euler(0f,45f,0f) * characterDir * Time.deltaTime;
            }else{
                rb.transform.position = rb.transform.position + Quaternion.Euler(0f,45f,0f) * characterDir * moveSpeed * Time.deltaTime;
            }
        }

        // Strafe Left
        if (Input.GetMouseButton(1) && Input.GetKey(KeyCode.A)){
            Debug.Log("Strafe Left");
        }

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            animator.SetBool("isJumping", true);
            Vector3 jumpForce = new Vector3(0, jumpHeight, 0);
            rb.AddForce(jumpForce, ForceMode.Impulse);
        }
        
    }

    public void IsGrounded()
    {
        if (Physics.Raycast(rb.transform.position, -Vector3.up, distToGround + 0.1f))
            isGrounded = true;
        else
            isGrounded = false;
    }
}
