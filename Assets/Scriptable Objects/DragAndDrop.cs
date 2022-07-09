using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler,IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private bool firstDrag = true;
    private Vector2[] firstDragPositions;

   public Vector2 startPos;
    public Vector2 startInventPos;

    private void Awake()
    {

        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        
    }
    private void Start()
    {
        
    }

    public void SetStartPosition()
    {
        startPos = rectTransform.anchoredPosition;
    }
    public void SetStartInventoryPosition()
    {
        startInventPos = rectTransform.anchoredPosition;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (firstDrag)
        {
            //firstDragPositions[]
          //  Debug.Log();

        }
        else { 
        
        }

        Debug.Log("OnBeginDrag");
        startPos = rectTransform.anchoredPosition;
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta/ canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = startPos;
    }

    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData eventData) {

        Debug.Log("OnPointerDown");
    }

    public void OnDrop(PointerEventData eventData)
    {
        // throw new System.NotImplementedException();
        //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = startPos;
    }
}
