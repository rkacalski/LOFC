using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormationController : MonoBehaviour
{
    [HideInInspector]
    public formationGrid selectedGrid;
    formationItem selectedItem;
    RectTransform rectTransform;

    private void Update()
    {
        if(selectedItem != null)
        {
            rectTransform.position = Input.mousePosition;
        }


        if (selectedGrid == null)
        {
            return;
        }
        if(Input.GetMouseButtonDown(0))
        {
            Vector2Int tileGridPos = selectedGrid.GetTileGridPos(Input.mousePosition);
            if (selectedItem == null)
            {
                selectedItem = selectedGrid.PickUpItem(tileGridPos.x, tileGridPos.y);
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
