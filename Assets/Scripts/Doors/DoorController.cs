using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrabStuff;

public class DoorController : MonoBehaviour
{
    public GameObject[] doors;
    int doorIndex;

    void Start()
    {
        doorIndex = 0;
        NextDoor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextDoor()
    {
        if (doorIndex == doors.Length) Loader.ToMainMenu();
        else
        Instantiate(doors[doorIndex++], transform);
    }
}
