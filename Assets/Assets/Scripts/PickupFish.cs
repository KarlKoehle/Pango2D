using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFish : MonoBehaviour
{
    public GameObject Fish;
    public SokobanPlayerMove Player;
    public int points = 10;
    public AudioSource playSound;

    private void Start() {
        Player = FindObjectOfType<SokobanPlayerMove>();
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Player"))
        {
            Player.points += points;
            playSound.Play();
            Destroy(gameObject);
            print("Fish has been collected");
        }
    }
}


