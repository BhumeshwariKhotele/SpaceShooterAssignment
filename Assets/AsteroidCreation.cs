using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCreation : MonoBehaviour
{

    public GameObject AsteroidPrefab; 
    public int x=2;
   
 void Start()
    {
        Invoke("SpawnAsteroid",1.0f);  //to create asteroids
    }

 private void SpawnAsteroid()
     {
         GameObject a = Instantiate(AsteroidPrefab); // for creation of asteroid
          float x=Random.Range(-36.4f,36.9f); //for different location of asteroid
         a.transform.position=new Vector3(x,2.0f,47.8f); //assigning the position
     }
 
  void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * x);        
    }

    
}
