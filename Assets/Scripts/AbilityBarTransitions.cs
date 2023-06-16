using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBarTransitions : MonoBehaviour
{
    private GameObject spellSlot1;

    // Start is called before the first frame update
    void Start()
    {
        spellSlot1 = GameObject.Find("Spell Slot 1");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        // Make the transition happen when 1 is pressed
        spellSlot1.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        if(Input.GetKey(KeyCode.Alpha1)){
            spellSlot1.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }
        
    }
}
