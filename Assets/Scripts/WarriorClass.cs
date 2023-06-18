using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarriorClass : ClassManager
{

    //Define ability names
    public enum Abilities
    {
        Swing=1, //dmg + gain combo point
        Whirlwind=2, //dmg + spend combo points
        Smash=3, //dmg + heal reduction + spend combo points
        Invigorate=4, //dmg + heal self
        Weaken=5, //dmg + slow target 
        Bash=6, //dmg + stun target
        Intimidate=7, //non dmg control
        Charge=8, //dmg + stun + movement to target
        Muster=9, //2min cd dmg buff
        CommandingShout=10, //1min cd group dmg buff
        Potion=11 //heal potion
    }

    private string className = "Warrior";

    public override string GetClassName()
    {
        return className;
    }

    // Begin ability definitions
    public override Sprite GetAbilityImage(int n)
    {
        Abilities spell = (Abilities)n;
        switch(spell)
        {
            case Abilities.Swing:
                return Resources.Load<Sprite>("Classes/Warrior/Barbarian/Barbarian20");
            default:
                return null;
        }

    }

}
