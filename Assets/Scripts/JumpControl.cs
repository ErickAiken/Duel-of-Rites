using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpControl : MonoBehaviour
{

    public bool isGrounded = true;
    
    private float jumpSpeed = 15.0f;
    private float gravity = -75.0f;
    private float ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(!isGrounded){
            ySpeed += gravity * Time.deltaTime;
            transform.position = transform.position + transform.up * ySpeed * Time.deltaTime + transform.up * gravity * Time.deltaTime * Time.deltaTime;
            if(transform.position.y <= 0){
                isGrounded = true;
                transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
            }

        }

        if(Input.GetKey(KeyCode.Space) && isGrounded){
            ySpeed = jumpSpeed;
            isGrounded = false;
        }
    }
}
