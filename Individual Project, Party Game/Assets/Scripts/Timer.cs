using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //Timers and Delays
    public float timeRemaining = 10;
    public float startDelay = 2f;
    public float endDelay = 2f;
    public float winDelay =2f;

    //Controlls the screen text
    public Text timerText;
    public Text intro;
    public Text win;
    public Text lose;
    //bool timerEnabled;
    bool turnedonRobots;
    public RobotVisible see;
    
    //timer controlls when player appears
    public GameObject repairman;
    public GameObject bMusic;
    public GameObject vMusic;
    public GameObject lMusic;
    public GameObject iMusic;

    void Start()
    {
        //Text on screen
        timerText.enabled = false;
        intro.enabled = true;
        win.enabled = false;
        lose.enabled = false;
        //player
        repairman.SetActive(false);
        //robot
        see.disableRobot();
        //music
        vMusic.SetActive(false);
        lMusic.SetActive(false);
        iMusic.SetActive(false);
        bMusic.SetActive(false);
        turnedonRobots= false;
    }

    void Update()
    {
        if(startDelay <= 0)
        {
            iMusic.SetActive(false);
            bMusic.SetActive(true);

            intro.enabled = false;
            timerText.enabled = true;
            repairman.SetActive(true);
            if(turnedonRobots == false)
            {
                see.enableRobot();
                turnedonRobots = true;
            }

            if (timeRemaining > 0 && Player.counter < 8)
            {
                timeRemaining -= Time.deltaTime;
                timerText.text = "Timer:" + Mathf.CeilToInt(timeRemaining);
            }
            else if(Player.counter == 8)
            {
                winupdate();
            }
            else
            {
                loseupdate();
            }
        }
        else
        {
            iMusic.SetActive(true);
            startDelay -= Time.deltaTime;
        }
    }

    void loseupdate()
    {
        repairman.SetActive(false);
        bMusic.SetActive(false);
        if(endDelay <= 0)
        {
            lose.enabled = false;
            lMusic.SetActive(false);
            see.disableRobot();
            timerText.enabled = false;
        }
        else
        {
            bMusic.SetActive(false);
            lMusic.SetActive(true);
            see.disableRobot();
            timerText.enabled = false;
            lose.enabled = true;
            endDelay -= Time.deltaTime;
        }
    }

    void winupdate()
    {
        repairman.SetActive(false);
        bMusic.SetActive(false);
        if(winDelay <=0)
        {
            win.enabled = false;
            vMusic.SetActive(false);
            see.disableRobot();
            timerText.enabled = false;
        }
        else
        {
            bMusic.SetActive(false);
            vMusic.SetActive(true);
            see.disableRobot();
            timerText.enabled = false;
            win.enabled = true;
            winDelay -= Time.deltaTime;
        }
    }
}
