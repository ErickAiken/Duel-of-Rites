using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{

    public static GameDataManager instance;

    // Define keybinds
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

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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


}


