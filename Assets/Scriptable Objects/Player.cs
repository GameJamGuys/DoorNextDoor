using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;
    // Start is called before the first frame update
    public GameObject testItem;


    public void Start()
    {
        Debug.Log("triiger");
        var item = GameObject.Find("TestItem").GetComponent<TestItem>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(item.gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triiger");
        var item = collision.GetComponent<TestItem>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(collision.gameObject);
        }
    }
    public void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}
