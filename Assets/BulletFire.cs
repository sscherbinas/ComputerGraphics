using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag.Equals("BrickWall")) {
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
 
    }
}