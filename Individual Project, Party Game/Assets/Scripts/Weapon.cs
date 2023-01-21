using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //what gets fired
    public GameObject bullet;
    //where bullet comes out from
    public Transform firep;
    //speed of bullet
    public float fireForce;
    public AudioSource Throw;
    
    //tells game to fire bullet
    public void fire()
    {
        GameObject projectile = Instantiate(bullet,firep.position, firep.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(firep.up * fireForce, ForceMode2D.Impulse);
        Throw.Play();
    }
}
