using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotVisible : MonoBehaviour
{
    public GameObject robot;
    public GameObject robot1;
    public GameObject robot2;
    public GameObject robot3;
    public GameObject robot4;
    public GameObject robot5;
    public GameObject robot6;
    public GameObject robot7;

    public void disableRobot()
    {
        robot.SetActive(false);
        robot1.SetActive(false);
        robot2.SetActive(false);
        robot3.SetActive(false);
        robot4.SetActive(false);
        robot5.SetActive(false);
        robot6.SetActive(false);
        robot7.SetActive(false);
    }
    
    public void enableRobot()
    {
        robot.SetActive(true);
        robot1.SetActive(true);
        robot2.SetActive(true);
        robot3.SetActive(true);
        robot4.SetActive(true);
        robot5.SetActive(true);
        robot6.SetActive(true);
        robot7.SetActive(true);
    }
}
