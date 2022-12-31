using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotController : MonoBehaviour
{
    public GameObject entrancePrefab;
    public GameObject exitPrefab;
    public Transform[] carsSlotArray = new Transform[8];
    private GameObject _entranceHud, _exitHud;

    public void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            carsSlotArray[i] = transform.GetChild(i);
        }
    }
    
    public Transform CurrentEntrance(int index)
    {
        return carsSlotArray[index].GetChild(0);
    }
    
    public void CreatEntranceAndExitHud(int index)
    {
        _entranceHud = Instantiate(entrancePrefab, carsSlotArray[index].GetChild(0).position,
                 Quaternion.Euler(0,0,0), carsSlotArray[index].GetChild(0));
        _exitHud = Instantiate(exitPrefab, carsSlotArray[index].GetChild(1));
    }

    public void ClearPart()
    {
        Destroy(_entranceHud);
        Destroy(_exitHud);
    }

}
