using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{

    [SerializeField] private GameObject gameManager;
    private GameDataManager gameData;
    private GameObject currentTarget;
    private PlayerData playerData;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        playerData = this.GetComponent<PlayerData>(); 
        gameData = gameManager.GetComponent<GameDataManager>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTarget = this.GetComponent<SelectObject>().getTargetObject();

        // Casts on Enemies
        if(currentTarget)
        {
            // Test casting ability
            if(Input.GetKeyDown(gameData.GetActionButtonKeybind1()))
            {
                currentTarget.GetComponent<EnemyInfo>().IncrementHealthPercent(-0.05f);
            }

            if(Input.GetKeyDown(gameData.GetActionButtonKeybind2()))
            {
                currentTarget.GetComponent<EnemyInfo>().IncrementHealthPercent(0.05f);
            }

        }

        // Casts on self
        if(Input.GetKeyDown(gameData.GetActionButtonKeybind3()))
        {
            playerData.IncrementHealthPercent(-0.05f);
        }

        if(Input.GetKeyDown(gameData.GetActionButtonKeybind4()))
        {
            playerData.IncrementHealthPercent(0.05f);
        }
    }
}
