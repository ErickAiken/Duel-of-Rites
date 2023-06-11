using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 5.0f;
    public float jumpValue = 5.0f;

    private Vector3 movementPlane;
    private Vector3 characterDir;
    public bool autoRun = false;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        movementPlane = Camera.main.transform.forward;
        characterDir = transform.forward;
        movementPlane.y = 0.0f;

        if(Input.GetKey(KeyCode.W) || autoRun){
            if(Input.GetMouseButton(0)){
                transform.position = transform.position + characterDir * moveSpeed * Time.deltaTime;
            }else{
                transform.position = transform.position + movementPlane * moveSpeed * Time.deltaTime;
            }
        }

        if(Input.GetMouseButton(0) && Input.GetMouseButton(1)){
            if( !Input.GetKey(KeyCode.W) && !autoRun){
                transform.position = transform.position + movementPlane * moveSpeed * Time.deltaTime;
            }
        }

        if(Input.GetKey(KeyCode.W)){
            autoRun = false;
        }

        if(Input.GetKey(KeyCode.BackQuote)){
            autoRun = true;
        }

        if(Input.GetKey(KeyCode.S)){
            transform.position = transform.position - movementPlane * moveSpeed * Time.deltaTime;
            autoRun = false;
        }

        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(Vector3.up * rotateSpeed * 15.0f * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(-Vector3.up * rotateSpeed * 15.0f * Time.deltaTime);
        }

        if (Input.GetMouseButton(1) && Input.GetKey(KeyCode.D)){
            Debug.Log("Strafe Right");
        }

        if (Input.GetMouseButton(1) && Input.GetKey(KeyCode.A)){
            Debug.Log("Strafe Left");
        }

        if(Input.GetKey(KeyCode.Space)){
            Debug.Log("JUMP");
        }

        
    }
}
