using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAsteroid : MonoBehaviour
{
    int asteroidscore=1;
    int score=0;
    

    private void OnCollisionEnter(Collision collision)
    {
     if(collision.gameObject.CompareTag("Asteroid")) // checking for collision
        {
        print(collision.gameObject.tag); // printing tag
        ScoreCalculator(asteroidscore); //sending score
        Destroy(collision.gameObject,1.0f);  //if colliding with bullet the asteroid getting destroyed
        }
    }
     void ScoreCalculator(int value)  //calculating the score and printing
    {
        score=score+value;
        print("The score is "+score);
    }
    
}
