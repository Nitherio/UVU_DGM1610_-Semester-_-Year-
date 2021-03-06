﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    
    private int score;

    public TextMeshProUGUI scoreText;

    
    //Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
        scoreText.text = "Score: " + score;
        isGameActive = true;
    }

    //updates score
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void Button_click()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

