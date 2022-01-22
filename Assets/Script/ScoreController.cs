using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreController : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private int score = 0;
    private void Awake()
    {
        scoreText=GetComponent<TextMeshProUGUI>();
    }
    public void IncreaseScore(int increment)
    {
        score += increment;
        RefereshUI();
    }

    private void RefereshUI()
    {
        scoreText.text = "Score : " + score;
    }
}
