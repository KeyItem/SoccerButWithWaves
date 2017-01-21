﻿using System.Collections;
using UnityEngine;

public class MainMenuInputManager : MonoBehaviour
{
    private MainMenuController mainMenuController;

    [Header("Input Attributes")]
    public string playerNumber;

    public bool canReceiveInput = false;

    private float xAxis;

    void Start()
    {
        mainMenuController = GameObject.FindGameObjectWithTag("GameController").GetComponent<MainMenuController>();

        GetPlayerInfo();
    }
    
    void Update()
    {
        GetInput();
    }

    void GetPlayerInfo()
    {
        playerNumber = tag;
    }

    void GetInput()
    {
        if (canReceiveInput)
        {
            xAxis = Input.GetAxisRaw("Horizontal" + playerNumber);

            if (xAxis != 0)
            {
                if (xAxis > 0)
                {
                    mainMenuController.MovePlayerToPosition("Right", gameObject, playerNumber);
                }
                else if (xAxis < 0)
                {
                    mainMenuController.MovePlayerToPosition("Left", gameObject, playerNumber);
                }
            }
        }
    }
}