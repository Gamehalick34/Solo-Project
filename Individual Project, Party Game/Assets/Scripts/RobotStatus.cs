using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotStatus : MonoBehaviour
{
    public GameObject selfRobot;
    public void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.tag = "Fixed";
        selfRobot.SetActive(false);
    }
}
