using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergePlate : MonoBehaviour
{
    public MergeHolder holder1;
    public MergeHolder holder2;
    public GameObject coloredKey;

    void Update()
    {
        if(holder1.isHold && holder2.isHold)
        {
            holder1.holdKey.SetActive(false);
            holder2.holdKey.SetActive(false);

            coloredKey.SetActive(true);
        }
    }
}
