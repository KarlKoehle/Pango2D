using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
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
        score.text = "Score:" + scoreValue;
        life.text = "Life:" + lifeValue;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            scoreValue = 0;
            lifeValue = 1;
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }

        // Health  = GameOver
        if (lifeValue <= 0)
        {
            scoreValue = 0;
            lifeValue = 1;
          SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
}
