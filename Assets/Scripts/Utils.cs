using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    

    public static GameObject ReturnDecendantOfParent(GameObject parent, string descendantName)
    {
        foreach (Transform child in parent.transform)
        {                   
            if (child.name == descendantName)
            { 
                return child.gameObject;                 
            }
            else
            {
                ReturnDecendantOfParent(child.gameObject, descendantName);
            }                  
        }
        return null;
    }
}
