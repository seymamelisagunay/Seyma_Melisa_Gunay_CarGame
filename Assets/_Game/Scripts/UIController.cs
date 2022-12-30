using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
   public static float[,] TimeDirectionArray;
   
   /// <summary>
   /// It takes the value 1 for the right direction, -1 for the left direction and 0 for the forward direction.
   /// </summary>
   /// <param name="direction">direction parameter value.</param>
   void TimeDirectionCalculate(float direction)
   {
      TimeDirectionArray = new float[,] {{CarController.Timer, direction}};
      CarController.Timer = 0;
   }
   
   
   public void OnPointerDown(PointerEventData eventData)
   {
      TimeDirectionCalculate(0);
      if (gameObject.CompareTag("LeftBtn"))
      {
         CarController.TurnLeft = true;
      }
      else
      {
         CarController.TurnRight = true;
      }
      
   }

   public void OnPointerUp(PointerEventData eventData)
   {
      CarController.CarTurnStop();
      if (gameObject.CompareTag("LeftBtn"))
      {
         TimeDirectionCalculate(-1);
      }
      else
      {
         TimeDirectionCalculate(1);
      }
   }

   
}
