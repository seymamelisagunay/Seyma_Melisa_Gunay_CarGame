using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SlotController slotController;
    public GameObject firstClickBtn;

    public void Start()
    {
        CarController.CarStop = true;
        slotController.CreatEntranceAndExitHud(0);
    }
    
    public void FirstClickCarStartBtn()
    {
        CarController.CarStop = false;
        firstClickBtn.SetActive(false);
    }
}
