using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameplatePointing : MonoBehaviour
{

    public GameObject mainCamera;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mainCamera.transform);
    }
}
