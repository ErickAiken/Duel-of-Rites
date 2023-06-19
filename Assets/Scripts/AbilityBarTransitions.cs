using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBarTransitions : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    private GameDataManager gameData;
    private GameObject spellSlot1;
    private GameObject spellSlot2;
    private GameObject spellSlot3;
    private GameObject spellSlot4;
    private GameObject spellSlot5;
    private GameObject spellSlot6;
    private GameObject spellSlot7;
    private GameObject spellSlot8;
    private GameObject spellSlot9;
    private GameObject spellSlot10;
    private GameObject spellSlot11;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        gameData = gameManager.GetComponent<GameDataManager>();
        spellSlot1 = GameObject.Find("Spell Slot 1");
        spellSlot2 = GameObject.Find("Spell Slot 2");
        spellSlot3 = GameObject.Find("Spell Slot 3");
        spellSlot4 = GameObject.Find("Spell Slot 4");
        spellSlot5 = GameObject.Find("Spell Slot 5");
        spellSlot6 = GameObject.Find("Spell Slot 6");
        spellSlot7 = GameObject.Find("Spell Slot 7");
        spellSlot8 = GameObject.Find("Spell Slot 8");
        spellSlot9 = GameObject.Find("Spell Slot 9");
        spellSlot10 = GameObject.Find("Spell Slot 10");
        spellSlot11 = GameObject.Find("Spell Slot 11");
    }

    // Update is called once per frame
    void Update()
    {
        //Press Ability Animations
        spellSlot1.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        spellSlot2.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        spellSlot3.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        spellSlot4.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        spellSlot5.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        spellSlot6.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        spellSlot7.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        spellSlot8.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        spellSlot9.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        spellSlot10.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        spellSlot11.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = true;
        if(Input.GetKey(gameData.GetActionButtonKeybind1())){
            spellSlot1.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }
        if(Input.GetKey(gameData.GetActionButtonKeybind2())){
            spellSlot2.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }
        if(Input.GetKey(gameData.GetActionButtonKeybind3())){
            spellSlot3.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }
        if(Input.GetKey(gameData.GetActionButtonKeybind4())){
            spellSlot4.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }
        if(Input.GetKey(gameData.GetActionButtonKeybind5())){
            spellSlot5.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }
        if(Input.GetKey(gameData.GetActionButtonKeybind6())){
            spellSlot6.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }
        if(Input.GetKey(gameData.GetActionButtonKeybind7())){
            spellSlot7.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }
        if(Input.GetKey(gameData.GetActionButtonKeybind8())){
            spellSlot8.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }
        if(Input.GetKey(gameData.GetActionButtonKeybind9())){
            spellSlot9.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }
        if(Input.GetKey(gameData.GetActionButtonKeybind10())){
            spellSlot10.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }
        if(Input.GetKey(gameData.GetActionButtonKeybind11())){
            spellSlot11.GetComponent<DuloGames.UI.UIHighlightTransition>().enabled = false;
        }

        
    }
}
