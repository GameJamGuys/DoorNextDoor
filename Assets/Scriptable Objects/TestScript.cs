using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrabStuff;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetPosition(Transform obj) 
    {
        obj.position = Pointer.GetPointerWorldPosition2D();
       // Debug.Log(obj.position);
    }
}
