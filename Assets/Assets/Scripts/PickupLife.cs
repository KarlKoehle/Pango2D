using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupLife : PickupBase  //  PickupLife is a derived class from PickupBase.
{
    public int life = 1;

    public override void OnPickup()  //Overrides the inherited Player.Life values.
    {
        Player.life += life;
        // playsound??   ??
    }
}
