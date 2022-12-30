using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed, turnSpeed;
    public SlotController slotController;
    public static bool CarStop;
    public static bool TurnLeft, TurnRight;
    [HideInInspector] public int carProgress = 0;

    public static float Timer;
    public static bool Counting; 

    public void FixedUpdate()
    {
        if (!CarStop)
        {
            Timer += Time.deltaTime;
            gameObject.transform.position += transform.forward * speed * Time.deltaTime;
            if (TurnRight)
            {
                CarTurn(1);
            }
            if (TurnLeft)
            {
                CarTurn(-1);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Exit"))
        {
            slotController.CurrentEntrance(carProgress);
        }
        else
        {
             carProgress++; 
        }
    }

    /// <summary>
    /// It takes the value 1 for the right direction and -1 for the left direction.
    /// </summary>
    /// <param name="direction">direction parameter value.</param>
    public void CarTurn(float direction)
    {
        transform.Rotate(new Vector3(0f, direction * 0.2f, 0f) * Time.deltaTime * turnSpeed * 100);
    }

    public static void CarTurnStop()
    {
        TurnLeft = TurnRight = false;
    }
}
