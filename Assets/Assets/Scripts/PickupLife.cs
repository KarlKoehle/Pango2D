using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupLife : PickupBase
{
    public int life = 1;

    public override void OnPickup()
    {
        Player.life += life;
        // playsound??
    }
}
