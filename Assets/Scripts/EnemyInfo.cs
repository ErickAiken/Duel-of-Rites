using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyInfo : MonoBehaviour
{

    [SerializeField] private string enemyName = "Opponent 1";
    private Image floatingHealthBar;
    private float healthPercent = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        floatingHealthBar = GameObject.Find("HPBar").GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        floatingHealthBar.fillAmount = healthPercent;
    }

    public float GetEnemyHealthPercent()
    {
        return healthPercent;
    }

    public void IncrementHealthPercent(float value)
    {
        healthPercent += value;
        if(healthPercent > 1.0f)
        {
            healthPercent = 1.0f;
        }
        if(healthPercent < 0.0f)
        {
            healthPercent = 0.0f;
        }
    }


}
