using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : PickupBase  //  PickupLife is a derived class from PickupBase.
{
    public GameObject OpenDoor;
    public GameObject ExitBlocked;

    public override void OnPickup()  //Overrides the inherited Player.Life values.
    {
        OpenDoor.SetActive(true);
        ExitBlocked.SetActive(false);
    }
}
