using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float DestroyTime = 0.5f;
    bool hasPackage;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("ouch!");
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, DestroyTime);
        }

        else if (other.tag == "Destination" && hasPackage)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
        }
    }
}
