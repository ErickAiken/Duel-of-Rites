using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    

    public static GameObject ReturnDecendantOfParent(GameObject parent, string descendantName)
    {
        //BROKEN DONT USE
        foreach (Transform child in parent.transform)
        {                   
            if (child.name == descendantName)
            { 
                return child.gameObject;                 
            }
            else
            {
                return ReturnDecendantOfParent(child.gameObject, descendantName);
            }                  
        }
        return null;
    }//ReturnDecendantOfParent


    public static float GetDistance(GameObject gobj1, GameObject gobj2)
    {
        return Vector3.Distance(gobj1.transform.position, gobj2.transform.position);
    }

}//Utils
