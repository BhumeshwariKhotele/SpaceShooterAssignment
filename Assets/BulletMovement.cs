using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public GameObject bulletObj;
    public float bulletspeed=1.0f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BulletCreation(Vector3.forward);
        } 
    }

        private void BulletCreation(Vector3 direction)
    {
        GameObject x = Instantiate(bulletObj);
        x.transform.position = transform.position;
        Rigidbody rb = x.GetComponent<Rigidbody>();
        rb.velocity= transform.rotation*Vector3.forward*bulletspeed;
    
    }
}
