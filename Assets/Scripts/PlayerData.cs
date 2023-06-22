using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{

    public enum CombatState
    {
        on, 
        off, 
    }

    public enum ControlState
    {
        normal,
        stunned,
        slowed,
    }

    private float playerHealth = 1.0f;
    private float enemyHealth;
    private GameObject playerUnitFrame;
    private GameObject playerHealthBar;
    private GameObject playerHealthText;
    private GameObject enemyUnitFrame;
    private GameObject enemyHealthBar;
    private GameObject enemyHealthText;
    private GameObject currentTarget;
    private CombatState combatState;
    private ControlState controlState;
    

    // Start is called before the first frame update
    void Start()
    {

        combatState = CombatState.off;
        controlState = ControlState.normal;

        playerUnitFrame = GameObject.Find("Unit Frame (Player)");
        playerHealthBar = playerUnitFrame.transform.Find("Bar (Health)").gameObject;
        playerHealthText = playerHealthBar.transform.Find("Text Group").gameObject.transform.Find("Percentage Text").gameObject;

        enemyUnitFrame = this.GetComponent<SelectObject>().getTargetFrame();
        enemyHealthBar = enemyUnitFrame.transform.Find("Bar (Health)").gameObject;
        enemyHealthText = enemyHealthBar.transform.Find("Text Group").gameObject.transform.Find("Percentage Text").gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        currentTarget = this.GetComponent<SelectObject>().getTargetObject();
        updatePlayerHealth();
        updateEnemyHealth();
    }

    private void updatePlayerHealth()
    {
        // Update the fill amount
        playerHealthBar.GetComponent<DuloGames.UI.UIProgressBar>().fillAmount = playerHealth;

        // Update the text amount
        playerHealthText.GetComponent<Text>().text = Mathf.Round((playerHealth*100.0f)).ToString() + "%";

    }

    private void updateEnemyHealth()
    {
        if(!currentTarget)
        {
            return;
        }
        enemyHealth = currentTarget.GetComponent<EnemyInfo>().GetEnemyHealthPercent();

        // Update the fill amount
        enemyHealthBar.GetComponent<DuloGames.UI.UIProgressBar>().fillAmount = enemyHealth;

        // Update the text amount
        enemyHealthText.GetComponent<Text>().text = Mathf.Round((enemyHealth*100.0f)).ToString() + "%";

    }

    public void IncrementHealthPercent(float value)
    {
        playerHealth += value;
        if(playerHealth > 1.0f)
        {
            playerHealth = 1.0f;
        }
        if(playerHealth < 0.0f)
        {
            playerHealth = 0.0f;
        }
    }


}
