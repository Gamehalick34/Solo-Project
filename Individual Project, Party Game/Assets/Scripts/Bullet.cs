using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject particleEffect;
    public void OnTriggerEnter2D(Collider2D other)
    {
        switch(other.gameObject.tag)
        {
            case"Wall":
            Effect();
            break;
            
            case"Broken":
            Effect();
            Player.counter++;
            break;
            
            case"Fixed":
            Effect();
            break;
        }
    }

    public void Effect()
    {
        Instantiate(particleEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
