using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exit : MonoBehaviour
{

    public string nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }
           

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Player"))
        {
            print("Exit");
       
        SceneManager.LoadScene(nextLevel, LoadSceneMode.Single); 
        }
    }

}
