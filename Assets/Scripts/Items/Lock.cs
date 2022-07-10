using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Lock : MonoBehaviour, IDropHandler
{
    public DoorLogic door;
    public GameObject key;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == key)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.SetActive(false);

           
            StartCoroutine(Remove());
        }     
    }

    IEnumerator Remove()
    {
        GetComponent<Animator>().Play("Remove");
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
        if (door) door.ActiveButton();
    }

}
