using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassManager : MonoBehaviour
{
    private string className;

    public virtual string GetClassName(){
        return className;
    }

    public virtual Sprite GetAbilitySprite(int n)
    {
        Sprite im = null;
        return im;
    }

}
