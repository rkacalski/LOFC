using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class formDrop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<RectTransform>().sizeDelta = new Vector2(75, 117);
            eventData.pointerDrag.transform.GetChild(0).gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(30, 30);
            eventData.pointerDrag.GetComponent<DragDrop>().range.fontSize = 21;

            //set other items invisibnle
            for (int i = 2; i < 9; i++)
            {
                eventData.pointerDrag.transform.GetChild(i).gameObject.SetActive(false);
            }

        }
        eventData.pointerDrag.GetComponent<DragDrop>().inPanel = true;
        Debug.Log(eventData.pointerDrag.GetComponent<DragDrop>().inPanel);

    }

}

