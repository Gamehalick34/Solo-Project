using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //helpes rotate player
    public float rotationoffset;
    //where bullet comes out of
    public Weapon weapon;
    public static int counter = 0;
    //used to test score in game
    //public int score;

    void Update()
    {
        //score = counter;
        ProcessInputs();
        RotatePlayer();
    }

    //player follow mouse good
    void RotatePlayer()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);

        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0,0, angle + rotationoffset));
    }

    //click mouse go pew
    void ProcessInputs()
    {
        if(Input.GetMouseButtonDown(0))
        {
            weapon.fire();
        }
    }
}
