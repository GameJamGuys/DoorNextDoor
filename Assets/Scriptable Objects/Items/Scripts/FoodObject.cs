using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food object", menuName = "Inventory System/Items/Food")]
public class FoodObject : ItemObject
{
    public int restoreHealthValue;
    public void Awake()
    {
        type = ItemType.Food;
    }

}
