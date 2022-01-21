using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFish : PickupBase    //  PickupFishe is a derived class from PickupBase.
{
    public int points = 1;

    public override void OnPickup()
    {
        Player.points += points;
      //  playSound.Play(FishPickup);  
    }
}


