using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickupBase : MonoBehaviour 
{
    public AudioSource playSound;

    private void Awake()
    {
       
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


