using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IInitializePotentialDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 defPosition;
    private Vector3 originalPosition;
    private Vector2 origSize;
    public GameObject origParent;
    public GameObject newParent;
    public bool inPanel;
    public Text range;
    public int cardCost;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        defPosition = GetComponent<RectTransform>().localPosition;
        originalPosition = GetComponent<RectTransform>().localPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        inPanel = false;
        Debug.Log("OnBeginDrag");
        Debug.Log(inPanel);
        canvasGroup.blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.blocksRaycasts = true;

        if (inPanel == true)
        {
            defPosition = originalPosition;
        }
        else
        {
            gameObject.transform.parent = origParent.transform;
            this.rectTransform.localPosition = defPosition;
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        GetComponent<RectTransform>().sizeDelta = new Vector2(128, 198);
        transform.GetChild(0).gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 50);
        range.fontSize = 40;
        gameObject.transform.parent = newParent.transform;

        for (int i = 2; i < 9; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }

        Debug.Log("OnPointerDown");
    }

    public void OnInitializePotentialDrag(PointerEventData ped)
    {
        ped.useDragThreshold = false;
    }

}
