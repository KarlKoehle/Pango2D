using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyVertPatrol : EnemyPatrolBase
{
  

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * moveSpeed;

        if (transform.position.y <= -patrolrange)
        {
            moveSpeed = Mathf.Abs(moveSpeed);
        }

        else if (transform.position.y >= patrolrange)
        {
            moveSpeed = -Mathf.Abs(moveSpeed);
        }
    }
}
