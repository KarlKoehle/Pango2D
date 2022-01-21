using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyVertPatrol : MonoBehaviour
{
    public float moveSpeed;
    public float patrolrange;

    public AudioSource playSound;  //Sound  *Squawk

  //  public GameObject enemy;

    public PlayerMove Player;
    private int points = 1;
    private int life = 1;

    private void Start()
    {
        moveSpeed = 2f;
        Player = FindObjectOfType<PlayerMove>();
    }

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * moveSpeed;

        if (transform.position.y <= -5)
        {
            moveSpeed = -moveSpeed;
        }

        if (transform.position.y >= 5)
        {
            moveSpeed = -moveSpeed;
        }
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Player"))
        {
            Player.points -= points;
            Player.life -= life;
            playSound.Play();
        }
    }
}
