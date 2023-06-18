using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconManager : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    private GameDataManager gameData;
    private ClassManager playerClass;
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
    private bool isUpdated = false;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        gameData = gameManager.GetComponent<GameDataManager>();
        playerClass = gameData.GetPlayerClass();
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
        if(!isUpdated)
        {
            UpdateIcons();
        }
    }

    private void UpdateIcons()
    {
        Debug.Log(playerClass.GetAbilityImage(gameData.GetAbilitySlotNumber(1)));
        spellSlot1.GetComponent<Image>().sprite = playerClass.GetAbilityImage(gameData.GetAbilitySlotNumber(1));
        isUpdated = true;

    }

}//IconManager
