using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formationGrid : MonoBehaviour
{
    public const float tileSizeWidth = 135;
    public const float tileSizeHeight = 135;
    public int gridSizeWidth = 6;
    public int gridSizeHeight = 3;
    formationItem[,] formSlots;

    [SerializeField] GameObject itemPref;
    [SerializeField] GameObject itemPref2;

    RectTransform rectTransform;
    Vector2 positionOnGrid = new Vector2();
    Vector2Int tileGridPosition = new Vector2Int();


    public void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        Init(gridSizeWidth, gridSizeHeight);
        formationItem testItem = Instantiate(itemPref).GetComponent<formationItem>();
        PlaceItem(testItem, 4, 2);

        formationItem testItem2 = Instantiate(itemPref2).GetComponent<formationItem>();
        PlaceItem(testItem2, 0, 0);
    }

    private void Init(int width, int height)
    {
        formSlots = new formationItem[width, height];
        Vector2 size = new Vector2(width * tileSizeWidth, height * tileSizeHeight);
        rectTransform.sizeDelta = size;
    }

    public Vector2Int GetTileGridPos(Vector2 mousePosition)
    {
        positionOnGrid.x = mousePosition.x - rectTransform.position.x;
        positionOnGrid.y = rectTransform.position.y - mousePosition.y;

        tileGridPosition.x = (int)(positionOnGrid.x / tileSizeWidth);
        tileGridPosition.y = (int)(positionOnGrid.y / tileSizeHeight);

        return tileGridPosition;
    }

    public void PlaceItem(formationItem item, int posX, int posY)
    {
        RectTransform rectTransform = item.GetComponent<RectTransform>();
        rectTransform.SetParent(this.rectTransform);
        formSlots[posX, posY] = item;

        Vector2 position = new Vector2();
        position.x = (tileSizeWidth / 2) + posX * tileSizeWidth;
        position.y = -(posY * tileSizeHeight + tileSizeHeight / 2);

        rectTransform.localPosition = position;
    }

    public formationItem PickUpItem(int x, int y)
    {
        formationItem toReturn = formSlots[x, y];
        formSlots[x, y] = null;
        return toReturn;
    }
}
