using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickupBase : MonoBehaviour 
{
    public SokobanPlayerMove Player;
    public AudioSource playSound;

    private void Awake()
    {
        Player = FindObjectOfType<SokobanPlayerMove>();
    }

    void OnTriggerEnter2D(Collider2D hit)
    {

        if (hit.CompareTag("Player"))
        {
            OnPickup();

            if (playSound != null)
            {
                playSound.Play();
            }

            Destroy(gameObject);

            // print("Item has been collected");
        }
    }

    public abstract void OnPickup();
   
}


