using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDataManager : MonoBehaviour
{
    // This class holds all the data needed to transition scenes.
    public static GameDataManager instance;

    // Define ability keybinds
    private KeyCode actionButtonKeybind1 = KeyCode.Alpha1;
    private KeyCode actionButtonKeybind2 = KeyCode.Alpha2;
    private KeyCode actionButtonKeybind3 = KeyCode.Alpha3;
    private KeyCode actionButtonKeybind4 = KeyCode.Alpha4;
    private KeyCode actionButtonKeybind5 = KeyCode.Alpha5;
    private KeyCode actionButtonKeybind6 = KeyCode.Alpha6;
    private KeyCode actionButtonKeybind7 = KeyCode.Alpha7;
    private KeyCode actionButtonKeybind8 = KeyCode.Alpha8;
    private KeyCode actionButtonKeybind9 = KeyCode.Alpha9;
    private KeyCode actionButtonKeybind10 = KeyCode.Alpha0;
    private KeyCode actionButtonKeybind11 = KeyCode.Minus;

    // Define class
    private ClassManager playerClass = new WarriorClass();

    // Define race and sex
    private bool isMale = true;
    private string race = "Human";

    // Define the armor set
    private string armorSetPath = "HumanMaleBasicArmor";
    

    // Define which ability is assigned to what spell slot
    private int ability1 = 1;
    private int ability2 = 2;
    private int ability3 = 3;
    private int ability4 = 4;
    private int ability5 = 5;
    private int ability6 = 6;
    private int ability7 = 7;
    private int ability8 = 8;
    private int ability9 = 9;
    private int ability10 = 10;
    private int ability11 = 11;


    //Methods
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public ClassManager GetPlayerClass()
    {
        return playerClass;
    }

    // Each ability number has an assigned slot number
    public int GetAbilitySlotNumber(int abilityNumber)
    {
        switch(abilityNumber){
            case 1:
                return ability1;
                break;
            case 2:
                return ability2;
                break;
            case 3:
                return ability3;
                break;
            case 4:
                return ability4;
                break;
            case 5:
                return ability5;
                break;
            case 6:
                return ability6;
                break;
            case 7:
                return ability7;
                break;
            case 8:
                return ability8;
                break;
            case 9:
                return ability9;
                break;
            case 10:
                return ability10;
                break;
            case 11:
                return ability11;
                break;
            default:
                return -1;
        }
    }

    public string GetArmorSetPath()
    {
        return armorSetPath;
    }

    public KeyCode GetActionButtonKeybind1()
    {
        return actionButtonKeybind1;
    }

    public KeyCode GetActionButtonKeybind2()
    {
        return actionButtonKeybind2;
    }

    public KeyCode GetActionButtonKeybind3()
    {
        return actionButtonKeybind3;
    }

    public KeyCode GetActionButtonKeybind4()
    {
        return actionButtonKeybind4;
    }

    public KeyCode GetActionButtonKeybind5()
    {
        return actionButtonKeybind5;
    }

    public KeyCode GetActionButtonKeybind6()
    {
        return actionButtonKeybind6;
    }

    public KeyCode GetActionButtonKeybind7()
    {
        return actionButtonKeybind7;
    }

    public KeyCode GetActionButtonKeybind8()
    {
        return actionButtonKeybind8;
    }

    public KeyCode GetActionButtonKeybind9()
    {
        return actionButtonKeybind9;
    }

    public KeyCode GetActionButtonKeybind10()
    {
        return actionButtonKeybind10;
    }

    public KeyCode GetActionButtonKeybind11()
    {
        return actionButtonKeybind11;
    }


}//GameDataManager


