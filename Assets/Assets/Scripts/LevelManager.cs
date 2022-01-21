using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;
    public static int life;
    public Text lifeTotal;
    public SokobanPlayerMove Player;
    public GameObject OpenDoor;
    public GameObject ExitBlocked;
   

    void Awake()
    {
        Player = FindObjectOfType<SokobanPlayerMove>();
    }

    void Update()
    {
        //Post Points and Life to Screen
        score.text = "Score:" + scoreValue + Player.points;
        lifeTotal.text = "Life:" + life + Player.life;   //***** WIP Work In Progress

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
