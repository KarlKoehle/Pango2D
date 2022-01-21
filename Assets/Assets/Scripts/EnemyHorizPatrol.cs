using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyHorizPatrol : EnemyPatrolBase
{

    void Update()
    {
        transform.position += transform.right * Time.deltaTime * moveSpeed;

        if (transform.position.x >= patrolrange)
        {
            moveSpeed = -Mathf.Abs(moveSpeed);
        }

        else if (transform.position.x <= -patrolrange)
        {
            moveSpeed = Mathf.Abs(moveSpeed);
        }
    }
}
