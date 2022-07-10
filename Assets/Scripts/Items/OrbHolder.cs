using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OrbHolder : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragAndDrop>().enabled = false;

            Destroy(gameObject);
        }
    }

}
