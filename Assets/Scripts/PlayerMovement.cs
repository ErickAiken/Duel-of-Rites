using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 5.0f;
    public bool autoRun = false;
    public float jumpHeight = 50f;

    public float distToGround;


    private Vector3 movementPlane;
    private Vector3 characterDir;
    private PlayerData playerData;

    Rigidbody rb;
    Collider cldr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cldr = GetComponent<CapsuleCollider>();
        distToGround = cldr.bounds.extents.y;
    }

    // Update is called once per frame
    void Update()
    {
        
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
        }

        if(Input.GetMouseButton(0) && Input.GetMouseButton(1)){
            if( !Input.GetKey(KeyCode.W) && !autoRun){
                rb.transform.position = rb.transform.position + movementPlane * moveSpeed * Time.deltaTime;
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
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Vector3 jumpForce = new Vector3(0, jumpHeight, 0);
            rb.AddForce(jumpForce, ForceMode.Impulse);
        }
        
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(rb.transform.position, -Vector3.up, distToGround + 0.1f);
    }
}
