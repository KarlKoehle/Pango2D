﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;
    public static int lifeValue = 1;
    public Text life;
    private PlayerMove Player;


    void Awake()
    {
        Player = FindObjectOfType<PlayerMove>();
    }

    void Update()
    {
        //Post Points and Life to Screen
        score.text = "Score:" + scoreValue + Player.points;
        life.text = "Life:" + lifeValue + Player.life;   //***** WIP Work In Progress

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }

        // Health  = GameOver
        if (Player.points <= 0)
        {
          SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
}
