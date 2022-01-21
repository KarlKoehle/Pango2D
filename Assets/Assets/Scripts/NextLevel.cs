using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nextLevel;

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Player"))
        {
           // print("Exit");
       
        SceneManager.LoadScene(nextLevel, LoadSceneMode.Single); 
        }
    }
}
