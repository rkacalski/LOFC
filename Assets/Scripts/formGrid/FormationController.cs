using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormationController : MonoBehaviour
{
    [HideInInspector]
    public formationGrid selectedGrid;

    formationItem selectedItem;
    RectTransform rectTransform;

    [SerializeField] List<objectForm> items;
    [SerializeField] GameObject itemPref;
    [SerializeField] Transform canvasTransform;

    void Update()
    {
        /**
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (selectedItem == null)
            {
                formationItem invenItem = Instantiate(itemPref).GetComponent<formationItem>();
                selectedItem = invenItem;
                rectTransform = invenItem.GetComponent<RectTransform>();
                rectTransform.SetParent(canvasTransform);

                int randItem = UnityEngine.Random.Range(0, items.Count);
                Debug.Log(randItem);
                invenItem.Set(items[randItem]);
            }
        }
        **/

        //Icon Drag
        if(selectedItem != null)
        {
            rectTransform.position = Input.mousePosition;
        }
        if (selectedGrid == null)
        {
            return;
        }
        //Move object on Grid
        if(Input.GetMouseButtonDown(0))
        {
            Vector2Int tileGridPos = selectedGrid.GetTileGridPos(Input.mousePosition);
            //pickup item
            if (selectedItem == null)
            {
                selectedItem = selectedGrid.PickUpItem(tileGridPos.x, tileGridPos.y);
                //place item
                if(selectedItem != null)
                {
                    rectTransform = selectedItem.GetComponent<RectTransform>();
                }
            }
            else
            {
                selectedGrid.PlaceItem(selectedItem, tileGridPos.x, tileGridPos.y);
                selectedItem = null;
            }

            //Debug.Log(selectedGrid.GetTileGridPos(Input.mousePosition));
        }
        
    }
}
