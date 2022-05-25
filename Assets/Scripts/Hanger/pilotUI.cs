using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pilotUI : MonoBehaviour
{
    public GameObject[] cardSlots;
    public List<Card> testList = new List<Card>();
    public List<Card> tempBinder = new List<Card>();

    public string selectedVehicle;
    public pilotLists pilotList;

    int newAtk;
    int newDef;

    void Start()
    {
        selectedVehicle = "slave1"; //Change to helper variable later
        initateTempBidner(selectedVehicle);

        for(int i = 0; i < tempBinder.Count; i++)
        {
            print(i + tempBinder[i].cardName);
        }

        DisplayCards();
        if (pilotList.slave1.ContainsKey("dVader_2star"))
        {
            //print(pilotList.slave1["dVader_2star"]);
        }
    }

    void Update()
    {
        //update cards when page changes
    }

    void initateTempBidner(string vehicleName)
    {
        if(vehicleName.Equals("slave1"))
        {
            for(int i = 0; i < testList.Count; i++)
            {
                string keyVal = testList[i].cardName.Substring(0, testList[i].cardName.LastIndexOf("_"));
                if (pilotList.slave1.ContainsKey(keyVal))
                {
                    tempBinder.Add(testList[i]);
                }
            }
        }
    }

    public string getKeyValue(string vehicleName, string cardName)
    {
        if (vehicleName.Equals("slave1"))
        {
            if (vehicleName.Equals("slave1"))
            {
                if (pilotList.slave1.ContainsKey(cardName))
                {
                    return pilotList.slave1[cardName];
                }
                return "";
            }
            return "";
        }
        return "";
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
                cardSlots[i].transform.GetChild(5).GetComponent<Text>().text = getKeyValue(selectedVehicle, tempBinder[i].cardName.Substring(0, tempBinder[i].cardName.LastIndexOf("_")));

                //atk

                //def

                //tags

                //button stuff

                //Setting active
            }
            if (i > cardCount - 1)
            {
                cardSlots[i].gameObject.SetActive(false);
            }
        }
    }
}
