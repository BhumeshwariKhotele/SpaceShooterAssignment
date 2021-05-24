using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSpaceship : MonoBehaviour
{
private void  SpaceShipDestroy(Collision collision)
{ 
   //if spaceship collides asteroid the spaceship will destroy and Game over
if(collision.gameObject.CompareTag("Asteroid"))
{
    Destroy(this,2.0f);
    print("The Asteroid hit Spaceship\nGame Over");
}
   
}
}
