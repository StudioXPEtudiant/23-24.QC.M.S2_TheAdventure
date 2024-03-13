using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Experience : MonoBehaviour
{
    public Image experienceBar;
    public TMP_Text playerLevelTxt;
    public int playerLevel = 1;
    public float currentXP = 0;
    public float maxXP = 100;
    public float rateXP = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentXP >= maxXP)
        {
            float reste = currentXP - maxXP;
            playerLevel += 1;
            playerLevelTxt.text = playerLevel;
            currentXP = 0 + reste;
            maxXP = maxXP * rateXP;
        } 
        experienceBar.fillAmount = currentXP / maxXP;
    }

    public void GainXP(float XP)
    {
        
        currentXP += XP;
        
    }
}
