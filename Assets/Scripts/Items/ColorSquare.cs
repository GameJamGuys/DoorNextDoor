using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorSquare : MonoBehaviour, IDropHandler
{
    public DoorLogic door;
    public GameObject key;
    public GameObject coloredKey;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == key)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                GetComponent<RectTransform>().anchoredPosition;
            coloredKey.SetActive(true);
            eventData.pointerDrag.SetActive(false);

           
            StartCoroutine(Remove());
        }     
    }

    IEnumerator Remove()
    {
       // GetComponent<Animator>().Play("Remove");
        yield return new WaitForSeconds(0.3f);
        // Destroy(gameObject);
        Instantiate(coloredKey, transform);
        //if (door) door.ActiveButton();
    }

}
