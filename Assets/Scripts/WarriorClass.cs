using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarriorClass : ClassManager
{

    //Define ability names
    public enum Abilities
    {
        Swing=1, 
        Whirlwind=2, 
        Smash=3, 
        Invigorate=4,
        Weaken=5, 
        Bash=6,
        Intimidate=7,
        Charge=8,
        Muster=9,
        CommandingShout=10,
        Potion=11
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
