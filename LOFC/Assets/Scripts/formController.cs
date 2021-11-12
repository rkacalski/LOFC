using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formController : MonoBehaviour
{
    public formGrid selectedGrid;
    formItem selectedItem;
    RectTransform rectTransform;

    private void Update()
    {
        if (selectedItem != null)
        {
            rectTransform.position = Input.mousePosition;
        }
        if (selectedGrid == null)
        {
            return;
        }

        if(Input.GetMouseButtonDown(0))
        {
            Vector2Int PosOnGrid = selectedGrid.getGridPosition(Input.mousePosition);

            if (selectedItem == null)
            {
                selectedItem = selectedGrid.pickUpItem(PosOnGrid.x, PosOnGrid.y);
                if(selectedItem != null)
                {
                    rectTransform = selectedItem.GetComponent<RectTransform>();
                }
            }
            else
            {
                selectedGrid.PlaceItem(selectedItem, PosOnGrid.x, PosOnGrid.y);
                selectedItem = null;
            }

        }
    }

    private void PlaceItem(Vector2Int GridPosition)
    {
        bool complete = selectedGrid.PlaceItem(selectedItem, GridPosition.x, GridPosition.y);
        if (complete)
        {
            selectedItem = null;

        }
    }
    private void pickUpItem(Vector2Int tileGridPosition)
    {
        selectedItem = selectedGrid.pickUpItem(tileGridPosition.x, tileGridPosition.y);
        if (selectedItem != null)
        {
            rectTransform = selectedItem.GetComponent<RectTransform>();
        }
    }
}
