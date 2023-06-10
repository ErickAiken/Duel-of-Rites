using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillSpin : MonoBehaviour
{

    public float spinSpeed = 1.0f;
    public Transform bladeObject;
    public Vector3 rotationDirection = new Vector3(0.0f, 0.0f, 0.0f);
    public float rot = 1.0f;

    // Update is called once per frame
    void Update()
    {
        rot += spinSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(rot,0f,0f);
    }
}
