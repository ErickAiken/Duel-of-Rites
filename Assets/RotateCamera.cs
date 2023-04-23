using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public Transform mainCamera;
    public float sensitivity = 2.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            Debug.Log(mainCamera.eulerAngles);
            Debug.Log(Input.GetAxis("Mouse X"));
            Debug.Log(Input.GetAxis("Mouse Y"));
            Debug.Log("HI");
            mainCamera.eulerAngles += sensitivity * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
        }
    }
}
