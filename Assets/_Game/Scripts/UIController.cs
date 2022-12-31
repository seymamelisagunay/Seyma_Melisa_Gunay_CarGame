using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
   public void OnPointerDown(PointerEventData eventData)
   {
      RecordCarMove.TimeDirectionSaveArray(0);
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
         RecordCarMove.TimeDirectionSaveArray(-1);
      }
      else
      {
         RecordCarMove.TimeDirectionSaveArray(1);
      }
   }

   
}
