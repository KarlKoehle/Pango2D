using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolBase : MonoBehaviour 
{
    public float moveSpeed = 2f;
    public float patrolrange = 2.5f;
    public AudioSource playSound;
    public int points = 1;
    public int life = 1;

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Player"))
        {
            ScoreManager.scoreValue -= points;
            ScoreManager.lifeValue -= life;
            playSound.Play();
        }
    }
}
