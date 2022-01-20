using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;
    public SokobanPlayerMove Player;
      
    public GameObject OpenDoor;
    public GameObject ExitBlocked;

    //GameObject DoorOpen;

    //public Exit exit;
   
    void Awake()
    {
        Player = FindObjectOfType<SokobanPlayerMove>();

      //  OpenDoor.SetActive(true);   //  not working unassigned Reference Exception - Has not been assigned.
      // ExitBlocked.SetActive(true);  

    }

    void Update()
    {
        score.text = "Score:" + scoreValue + Player.points;

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
