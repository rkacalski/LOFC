using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class copilot1UI : MonoBehaviour
{
    public GameObject[] cardSlots;
    public List<Card> tempBinder = new List<Card>();
    public List<int> origPos = new List<int>();

    //vehicle selectedVehicle;
    public pilotLists pilotList;

    int newAtk;
    int newDef;
    int tagCount;
    int pageNum;
    int loopCounter;
    float pageMax;
    public Text cardCount;

    void Start()
    {
        initateTempBidner(vehicleModHelper.selectedVehicle.displayName);

        pageNum = 1;
        pageMax = Mathf.Ceil(tempBinder.Count / 10f);

        DisplayCards();
    }

    void Update()
    {
        updatePage();
        updateCards();
    }

    void updatePage()
    {
        cardCount.text = pageNum.ToString() + "/" + pageMax.ToString();
    }

    public void nextPage()
    {
        if (tempBinder.Count > 0)
        {
            if (pageNum >= pageMax)
            {
                pageNum = 1;
            }
            else
            {
                pageNum = pageNum + 1;
            }
        }
    }

    public void prevPage()
    {
        if (tempBinder.Count > 0)
        {
            if (pageNum <= 1)
            {
                pageNum = (int)pageMax;
            }
            else
            {
                pageNum = pageNum - 1;
            }
        }
    }

    void initateTempBidner(string vehicleName)
    {
        if (vehicleName.Equals("Slave 1"))
        {
            for (int i = 0; i < playerCards.userCards.Count; i++)
            {
                string keyVal = playerCards.userCards[i].cardName.Substring(0, playerCards.userCards[i].cardName.LastIndexOf("_"));
                if (pilotList.slave1co.ContainsKey(keyVal) && playerCards.userCards[i].isPilot != true)
                {
                    tempBinder.Add(playerCards.userCards[i]);
                    origPos.Add(i);
                }
            }
        }
    }

    public string getKeyValue(string vehicleName, string cardName)
    {
        if (vehicleName.Equals("Slave 1"))
        {
            if (pilotList.slave1co.ContainsKey(cardName))
            {
                return pilotList.slave1co[cardName];
            }
            return "";
        }
        return "";
    }

    decimal getPilotMultAtk(string affinity)
    {
        if (affinity.Equals("S"))
        {
            return 16;
        }
        if (affinity.Equals("A"))
        {
            return 12;
        }
        if (affinity.Equals("B"))
        {
            return 8;
        }
        if (affinity.Equals("C"))
        {
            return 6;
        }
        if (affinity.Equals("D"))
        {
            return 4;
        }
        return 0;
    }

    decimal getPilotMultDef(string affinity)
    {
        if (affinity.Equals("S"))
        {
            return 8;
        }
        if (affinity.Equals("A"))
        {
            return 6;
        }
        if (affinity.Equals("B"))
        {
            return 4;
        }
        if (affinity.Equals("C"))
        {
            return 3;
        }
        if (affinity.Equals("D"))
        {
            return 2;
        }
        return 0;
    }

    void DisplayCards()
    {
        int cardCount = tempBinder.Count;

        for (int i = 0; i < 10; i++)
        {
            //limits
            if (i <= cardCount - 1)
            {
                //background
                bool Lightresult;
                bool Darkresult;
                bool Nuetralresult;
                char currentSide = tempBinder[i].side;
                Lightresult = currentSide.Equals('L');
                Darkresult = currentSide.Equals('D');
                Nuetralresult = currentSide.Equals('N');

                if (Lightresult == true)
                {
                    cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().color = new Color32(0, 0, 100, 110);
                }
                if (Darkresult == true)
                {
                    cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().color = new Color32(73, 10, 3, 110);
                }
                if (Nuetralresult == true)
                {
                    cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().color = new Color32(133, 81, 21, 110);
                }

                //name
                cardSlots[i].transform.GetChild(2).GetComponent<Text>().text = tempBinder[i].displayName;

                //art
                cardSlots[i].transform.GetChild(1).GetComponent<Image>().sprite = tempBinder[i].cardArt;

                //afinity
                cardSlots[i].transform.GetChild(5).GetComponent<Text>().text = getKeyValue(vehicleModHelper.selectedVehicle.displayName, tempBinder[i].cardName.Substring(0, tempBinder[i].cardName.LastIndexOf("_")));


                //atk
                cardSlots[i].transform.GetChild(6).GetComponent<Text>().text = "ATK: +" + Math.Round(((getPilotMultAtk(cardSlots[i].transform.GetChild(5).GetComponent<Text>().text) / 100m) * tempBinder[i].attack), 0).ToString();

                //def
                cardSlots[i].transform.GetChild(7).GetComponent<Text>().text = "Def: +" + Math.Round(((getPilotMultDef(cardSlots[i].transform.GetChild(5).GetComponent<Text>().text) / 100m) * tempBinder[i].attack), 0).ToString();

                //tags
                tagCount = tempBinder[i].tags.Count;
                for (int k = 0; k < 5; k++)
                {
                    if (tagCount != 5)
                    {
                        cardSlots[i].transform.GetChild(3).transform.GetChild(0).transform.GetChild(k).gameObject.SetActive(true);
                    }
                }
                for (int j = 0; j < 5; j++)
                {
                    if (j < tagCount)
                    {
                        cardSlots[i].transform.GetChild(3).transform.GetChild(0).transform.GetChild(j).GetComponent<Image>().sprite = tempBinder[i].tags[j];
                    }
                    else
                    {
                        cardSlots[i].transform.GetChild(3).transform.GetChild(0).transform.GetChild(j).gameObject.SetActive(false);

                    }
                }

                //button stuff
                cardSlots[i].transform.GetChild(8).transform.GetChild(4).GetComponent<Text>().text = origPos[i].ToString();


            }
            if (i > cardCount - 1)
            {
                cardSlots[i].gameObject.SetActive(false);
            }
        }
    }

    void updateCards()
    {
        if (pageNum == 1)
        {
            for (int i = 0; i < 10; i++)
            {
                cardSlots[i].gameObject.SetActive(true);
            }
            DisplayCards();
        }

        if (pageNum != 1)
        {
            loopCounter = (pageNum - 1) * 10;
            for (int i = 0; i < 10; i++)
            {
                if ((i + loopCounter) >= tempBinder.Count)
                {
                    break;
                }

                //background
                bool Lightresult;
                bool Darkresult;
                bool Nuetralresult;
                char currentSide = tempBinder[i + loopCounter].side;
                Lightresult = currentSide.Equals('L');
                Darkresult = currentSide.Equals('D');
                Nuetralresult = currentSide.Equals('N');

                if (Lightresult == true)
                {
                    cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().color = new Color32(0, 0, 100, 110);
                }
                if (Darkresult == true)
                {
                    cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().color = new Color32(73, 10, 3, 110);
                }
                if (Nuetralresult == true)
                {
                    cardSlots[i].transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().color = new Color32(133, 81, 21, 110);
                }

                //name
                cardSlots[i].transform.GetChild(2).GetComponent<Text>().text = tempBinder[i + loopCounter].displayName;

                //art
                cardSlots[i].transform.GetChild(1).GetComponent<Image>().sprite = tempBinder[i + loopCounter].cardArt;

                //afinity
                cardSlots[i].transform.GetChild(5).GetComponent<Text>().text = getKeyValue(vehicleModHelper.selectedVehicle.displayName, tempBinder[i + loopCounter].cardName.Substring(0, tempBinder[i + loopCounter].cardName.LastIndexOf("_")));

                //atk
                cardSlots[i].transform.GetChild(6).GetComponent<Text>().text = "ATK: +" + Math.Round(((getPilotMultAtk(cardSlots[i].transform.GetChild(5).GetComponent<Text>().text) / 100m) * tempBinder[i + loopCounter].attack), 0).ToString();

                //def
                cardSlots[i].transform.GetChild(7).GetComponent<Text>().text = "Def: +" + Math.Round(((getPilotMultDef(cardSlots[i].transform.GetChild(5).GetComponent<Text>().text) / 100m) * tempBinder[i + loopCounter].attack), 0).ToString();

                //tags
                tagCount = tempBinder[i + loopCounter].tags.Count;
                for (int k = 0; k < 5; k++)
                {
                    if (tagCount != 5)
                    {
                        cardSlots[i].transform.GetChild(3).transform.GetChild(0).transform.GetChild(k).gameObject.SetActive(true);
                    }
                }
                for (int j = 0; j < 5; j++)
                {
                    if (j < tagCount)
                    {
                        cardSlots[i].transform.GetChild(3).transform.GetChild(0).transform.GetChild(j).GetComponent<Image>().sprite = tempBinder[i + loopCounter].tags[j];
                    }
                    else
                    {
                        cardSlots[i].transform.GetChild(3).transform.GetChild(0).transform.GetChild(j).gameObject.SetActive(false);

                    }
                }

                //button stuff
                cardSlots[i].transform.GetChild(8).transform.GetChild(4).GetComponent<Text>().text = origPos[i + loopCounter].ToString();
            }

            for (int i = 0; i <= 9; i++)
            {
                if ((i + loopCounter) >= tempBinder.Count)
                {
                    cardSlots[i].gameObject.SetActive(false);
                }
                else
                {
                    cardSlots[i].gameObject.SetActive(true);
                }
            }
        }
    }
}
