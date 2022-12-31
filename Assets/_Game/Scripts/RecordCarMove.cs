using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class RecordCarMove : MonoBehaviour
{
    public static float[,] TimeDirectionArray = new float[80,2];
    public static float[,] timeDirectionSaveArray;
    public static int Register = 0;
    
    /// <summary>
    /// It takes the value 1 for the right direction, -1 for the left direction and 0 for the forward direction.
    /// </summary>
    /// <param name="direction">direction parameter value.</param>
    public static void TimeDirectionSaveArray(float direction)
    {
        TimeDirectionArray[Register, 0] = CarController.Timer;
        TimeDirectionArray[Register, 1] = direction;
        CarController.Timer = 0;
        Register++;
    }

    public static void ResetRegister()
    {
        Register = 0;
    }

    public static void SaveArray() // With the {{i,2n},{i,2n+1}} rule, we save matrices to the matrix.
    {
        for (int i = 0; i < 18; i++)
        {
            for (int j = 0; j <= Register; j++)
            {
                timeDirectionSaveArray[j,i*2] = TimeDirectionArray[j,0];
                timeDirectionSaveArray[j,i*2] = TimeDirectionArray[j,1];
            }
        }
    }

    public static void test()
    {
        for (int i = 0; i <= Register; i++)
        {
            
            Debug.Log(TimeDirectionArray[i,0]);
            Debug.Log(TimeDirectionArray[i,1]);
            
        }
    }
}
