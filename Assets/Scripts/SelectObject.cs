using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    private GameObject targetObject;
    private RaycastHit raycastHit;
    private Ray ray;

    [SerializeField] private GameObject targetFrame;



    // Start is called before the first frame update
    void Start()
    {
        targetFrame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        //Handle clicking enemies
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Input.GetMouseButtonDown(0)){
            if(Physics.Raycast(ray, out raycastHit, 100f)){
                if(raycastHit.collider.gameObject.tag == "Opponent"){
                    targetObject = raycastHit.collider.gameObject;
                    targetFrame.SetActive(true);
                }else{
                    targetObject = null;
                    targetFrame.SetActive(false);
                }
            }
        }

    }//Update

}//SelectObject
