using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeyColorCombination : MonoBehaviour, IDropHandler
{
    public GameObject firstKey;
    public GameObject secondKey;
    public GameObject coloredKey;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == firstKey)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                GetComponent<RectTransform>().anchoredPosition;
            coloredKey.GetComponent<RectTransform>().anchoredPosition =
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition;
            coloredKey.SetActive(true);
            eventData.pointerDrag.SetActive(false);
            secondKey.SetActive(false);


           // StartCoroutine(Remove());
        }
        else {
            if (eventData.pointerDrag == secondKey)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                    GetComponent<RectTransform>().anchoredPosition;
                coloredKey.GetComponent<RectTransform>().anchoredPosition =
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition;
                coloredKey.SetActive(true);
                eventData.pointerDrag.SetActive(false);
                firstKey.SetActive(false);


             //   StartCoroutine(Remove());
            }
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

    // Start is called before the first frame update
   
    // Update is called once per frame
   
}
