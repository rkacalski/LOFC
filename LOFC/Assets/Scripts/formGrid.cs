using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formGrid : MonoBehaviour
{
    public const float tileHeight = 135;
    public const float tileLength = 135;
    RectTransform rectTransform;
    formItem[,] formSlots;

    [SerializeField] int gridHeight = 3;
    [SerializeField] int gridLength = 6;
    [SerializeField] GameObject Testitem;
    [SerializeField] GameObject Testitem2;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        Init(gridLength, gridHeight);

        formItem newitem = Instantiate(Testitem).GetComponent<formItem>();
        PlaceItem(newitem, 1, 0);
        formItem newitem2 = Instantiate(Testitem2).GetComponent<formItem>();
        PlaceItem(newitem2, 4, 2);
    }

    Vector2 posOnGrid = new Vector2();
    Vector2Int tileGridPos = new Vector2Int();

    public Vector2Int getGridPosition(Vector2 mousePosition)
    {
        posOnGrid.x = mousePosition.x - rectTransform.position.x;
        posOnGrid.y = rectTransform.position.y - mousePosition.y;
        tileGridPos.x = (int)(posOnGrid.x / tileLength);
        tileGridPos.y = (int)(posOnGrid.y / tileHeight);

        return tileGridPos;
    }

    private void Init(int length, int width)
    {
        formSlots = new formItem[length, width];
        Vector2 size = new Vector2(length * tileLength, width * tileHeight);
        rectTransform.sizeDelta = size;
    }

    public bool PlaceItem(formItem inventoryItem, int posX, int posY)
    {
        if (BoundryCheck(posX, posY, inventoryItem.sizeX, inventoryItem.sizeY) == false)
        {
            return false;
        }
        PlaceItem1(inventoryItem, posX, posY);
        return true;
    }

    public void PlaceItem1(formItem inventoryItem, int posX, int posY)
    {
        RectTransform rectTransform = inventoryItem.GetComponent<RectTransform>();
        rectTransform.SetParent(this.rectTransform);

        for (int x = 0; x < inventoryItem.sizeX; x++)
        {
            for (int y = 0; y < inventoryItem.sizeY; y++)
            {
                formSlots[posX + x, posY + y] = inventoryItem;
            }
        }

        inventoryItem.onGridPositionX = posX;
        inventoryItem.onGridPositionY = posY;
        Vector2 position = CalculatePositionOnGrid(inventoryItem, posX, posY);
        rectTransform.localPosition = position;
    }

    public formItem pickUpItem(int x, int y)
    {
        formItem toReturn = formSlots[x, y];
        if (toReturn == null)
        {
            return null;
        }
        for (int ix = 0; ix < toReturn.sizeX; ix++)
        {
            for (int iy = 0; iy < toReturn.sizeY; iy++)
            {
                formSlots[toReturn.onGridPositionX + ix, toReturn.onGridPositionY + iy] = null;
            }
        }
        return toReturn;
    }

    public Vector2 CalculatePositionOnGrid(formItem item, int posX, int posY)
    {
        Vector2 position = new Vector2();
        position.x = posX * tileLength + tileLength * item.sizeX / 2;
        position.y = -(posY * tileHeight + tileHeight * item.sizeY / 2);
        return position;
    }

    bool PositionCheck(int posX, int posY)
    {
        if (posX < 0 || posY < 0)
        {
            return false;
        }

        if (posX >= gridLength || posY >= gridHeight)
        {
            return false;
        }

        return true;
    }

    public bool BoundryCheck(int posX, int posY, int width, int height)
    {
        if (PositionCheck(posX, posY) == false) 
        { 
            return false; 
        }

        posX += width - 1;
        posY += height - 1;

        if (PositionCheck(posX, posY) == false) 
        { 
            return false; 
        }

        return true;
    }
}
