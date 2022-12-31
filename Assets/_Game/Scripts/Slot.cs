using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public CarFirstDirection carFirstDirection;

    private void Awake()
    {
        if (carFirstDirection == CarFirstDirection.Left)
            transform.rotation = Quaternion.Euler(0, -90, 0);
        
        else if(carFirstDirection == CarFirstDirection.Right)
            transform.rotation = Quaternion.Euler(0, 90, 0);
        
        else if(carFirstDirection == CarFirstDirection.Up)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        
        else if(carFirstDirection == CarFirstDirection.Down)
            transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}

public enum CarFirstDirection
{
    Up = 0,
    Down = 1,
    Right = 2,
    Left = 3
}