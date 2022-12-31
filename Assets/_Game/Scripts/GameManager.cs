using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SlotController slotController;
    public GameObject car;
    public GameObject firstClickBtn; 
    public static int CarProgress = 0;

    public void Start()
    {
        slotController.CreatEntranceAndExitHud(CarProgress);
        ResetCarMove();
    }
    
    public void FirstClickCarStartBtn()
    {
        CarController.CarStop = false;
        firstClickBtn.SetActive(false);
    }

    public void ResetCarMove()
    {
        car.transform.position = slotController.CurrentEntrance(CarProgress).position;
        car.transform.rotation = slotController.CurrentEntrance(CarProgress).rotation;
        CarController.CarStop = true;
        firstClickBtn.SetActive(true);
        RecordCarMove.ResetRegister();
    }

}
