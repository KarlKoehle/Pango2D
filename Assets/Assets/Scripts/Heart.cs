using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public GameObject heart;
    public SokobanPlayerMove Player;

    public GameObject OpenDoor;
    public GameObject ExitBlocked;
      
    public AudioSource playSound;

    private void Start()
    {
        Player = FindObjectOfType<SokobanPlayerMove>();
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Player"))
        {
            // Player.points += points;
            playSound.Play();
            Destroy(gameObject);

            OpenDoor.SetActive(true);
            ExitBlocked.SetActive(false);

            print("Key has been collected");
                        
        }
    }
}





