using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lock : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision);
        Destroy(gameObject);
    }
}
