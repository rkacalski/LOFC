using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class evo1UI : MonoBehaviour
{
    public GameObject[] cardSlots;

    public static int cardOrigPos;
    public int cardCount;
    public int loopCounter;
    public int pageNum;
    public float pageMax;
    public Text pageText;
    public Text cardAmount;

    List<Card> tempBinder = new List<Card>();
    List<Card> sortedBinder = new List<Card>();
    List<int> origLoc = new List<int>();

    void Start()
    {
        //for final delete the not from 1 and 5 star
        for (int i = 0; i < playerCards.userCards.Count; i++)
        {
            if ((!playerCards.userCards[i].cardName.Contains("evomax")) && (!playerCards.userCards[i].cardName.Contains("evomax+")) && (!playerCards.userCards[i].cardName.Contains("awakened")) && (!playerCards.userCards[i].cardName.Contains("awakened+")))
            {
                if(playerCards.userCards[i].rarity.Equals(1) && (!playerCards.userCards[i].level.Equals(20)))
                {
                    tempBinder.Add(playerCards.userCards[i]);
                    origLoc.Add(i);
                }
                if (playerCards.userCards[i].rarity.Equals(2) && (playerCards.userCards[i].level.Equals(30)))
                {
                    tempBinder.Add(playerCards.userCards[i]);
                    origLoc.Add(i);
                }
                if (playerCards.userCards[i].rarity.Equals(3) && (playerCards.userCards[i].level.Equals(40)))
                {
                    tempBinder.Add(playerCards.userCards[i]);
                    origLoc.Add(i);
                }
                if (playerCards.userCards[i].rarity.Equals(4) && (playerCards.userCards[i].level.Equals(50)))
                {
                    tempBinder.Add(playerCards.userCards[i]);
                    origLoc.Add(i);
                }
                if (playerCards.userCards[i].rarity.Equals(5) && (!playerCards.userCards[i].level.Equals(60)))
                {
                    tempBinder.Add(playerCards.userCards[i]);
                    origLoc.Add(i);
                }
            }
        }
        pageNum = 1;
        DisplayCards();
    }

    void Update()
    {
        updatePage();
        updateCards();
    }

    public void updatePage()
    {
        pageText.text = pageNum + "/" + pageMax;
    }

    public void nextPage()
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

    public void prevPage()
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

    private void DisplayCards()
    {
        cardCount = sortedBinder.Count;
        cardAmount.text = sortedBinder.Count.ToString();
        pageMax = Mathf.Ceil(sortedBinder.Count / 10f);

        sortedBinder = tempBinder.OrderBy(x => x.rarity).ToList();
        sortedBinder.Reverse();

        for (int i = 0; i <= 9; i++)
        {
            //print(i)
            if (i <= cardCount - 1)
            {
                // Display Pannel Background
                bool Lightresult;
                bool Darkresult;
                bool Nuetralresult;
                char currentSide = sortedBinder[i].side;
                Lightresult = currentSide.Equals('L');
                Darkresult = currentSide.Equals('D');
                Nuetralresult = currentSide.Equals('N');

                if (Lightresult == true)
                {
                    cardSlots[i].transform.GetChild(0).GetComponent<Image>().color = new Color32(3, 17, 53, 255);
                }
                if (Darkresult == true)
                {
                    cardSlots[i].transform.GetChild(0).GetComponent<Image>().color = new Color32(53, 10, 3, 255);
                }
                if (Nuetralresult == true)
                {
                    cardSlots[i].transform.GetChild(0).GetComponent<Image>().color = new Color32(153, 101, 21, 255);
                }

                //display Card art
                cardSlots[i].transform.GetChild(1).GetComponent<Image>().sprite = sortedBinder[i].cardArt;

                //Display Card Name
                cardSlots[i].transform.GetChild(2).GetComponent<Text>().text = sortedBinder[i].displayName;

                //Display Card Level
                cardSlots[i].transform.GetChild(5).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i].level.ToString();

                //Display Card rarity
                if (sortedBinder[i].rarity == 1)
                {
                    cardSlots[i].transform.GetChild(3).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }
                if (sortedBinder[i].rarity == 2)
                {
                    cardSlots[i].transform.GetChild(3).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }
                if (sortedBinder[i].rarity == 3)
                {
                    cardSlots[i].transform.GetChild(3).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }
                if (sortedBinder[i].rarity == 4)
                {
                    cardSlots[i].transform.GetChild(3).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }
                if (sortedBinder[i].rarity == 5)
                {
                    cardSlots[i].transform.GetChild(3).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }

                //Display Card Cost
                cardSlots[i].transform.GetChild(4).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i].cost.ToString();

                //Display Card def
                cardSlots[i].transform.GetChild(6).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i].defense.ToString();

                //Display Card atk
                cardSlots[i].transform.GetChild(7).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i].attack.ToString();

                //Display Card ACC
                cardSlots[i].transform.GetChild(8).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i].accuracy.ToString();

                //Display Card EVA
                cardSlots[i].transform.GetChild(9).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i].evasion.ToString();

                //Display Card HP
                cardSlots[i].transform.GetChild(10).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i].HP.ToString();

                //Display Card Range
                cardSlots[i].transform.GetChild(11).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i].range;

                //Display Card ATK PTRN
                cardSlots[i].transform.GetChild(12).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i].atkPatern;

                //Display # of ATKs
                cardSlots[i].transform.GetChild(13).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i].NumofATKs;

                //Display Type Tags

                //Display in form?
                cardSlots[i].transform.GetChild(15).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i].inForm.ToString();

                //Set Array Pos
                cardSlots[i].transform.GetChild(16).transform.GetChild(1).GetComponent<Text>().text = i.ToString();

                //get card rarity
                cardSlots[i].transform.GetChild(16).transform.GetChild(2).GetComponent<Text>().text = sortedBinder[i].rarity.ToString();

                //get card rarity
                cardSlots[i].transform.GetChild(16).transform.GetChild(3).GetComponent<Text>().text = sortedBinder[i].cardName;

                //set orig array pos
                cardSlots[i].transform.GetChild(16).transform.GetChild(4).GetComponent<Text>().text = origLoc[i].ToString();
            }
            if (i > cardCount - 1)
            {
                cardSlots[i].gameObject.SetActive(false);
            }
        }
    }

    private void updateCards()
    {
        cardCount = sortedBinder.Count;

        if (pageNum == 1)
        {
            for (int i = 0; i <= 9; i++)
            {
                cardSlots[i].gameObject.SetActive(true);
            }
            DisplayCards();
        }

        if (pageNum != 1)
        {
            loopCounter = (pageNum - 1) * 10;
            for (int i = 0; i <= 9; i++)
            {
                cardSlots[i].transform.GetChild(3).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 0);
                cardSlots[i].transform.GetChild(3).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 0);
                cardSlots[i].transform.GetChild(3).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 0);
                cardSlots[i].transform.GetChild(3).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 0);
                cardSlots[i].transform.GetChild(3).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            }

            for (int i = 0; i <= 9; i++)
            {
                if ((i + loopCounter) >= cardCount)
                {
                    break;
                }

                // Display Pannel Background
                bool Lightresult;
                bool Darkresult;
                bool Nuetralresult;
                char currentSide = sortedBinder[i + loopCounter].side;
                Lightresult = currentSide.Equals('L');
                Darkresult = currentSide.Equals('D');
                Nuetralresult = currentSide.Equals('N');

                if (Lightresult == true)
                {
                    cardSlots[i].transform.GetChild(0).GetComponent<Image>().color = new Color32(3, 17, 53, 255);
                }
                if (Darkresult == true)
                {
                    cardSlots[i].transform.GetChild(0).GetComponent<Image>().color = new Color32(53, 10, 3, 255);
                }
                if (Nuetralresult == true)
                {
                    cardSlots[i].transform.GetChild(0).GetComponent<Image>().color = new Color32(153, 101, 21, 255);
                }

                //display Card art
                cardSlots[i].transform.GetChild(1).GetComponent<Image>().sprite = sortedBinder[i + loopCounter].cardArt;

                //Display Card Name
                cardSlots[i].transform.GetChild(2).GetComponent<Text>().text = sortedBinder[i + loopCounter].displayName;

                //Display Card Level
                cardSlots[i].transform.GetChild(5).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i + loopCounter].level.ToString();

                //Display Card rarity
                if (sortedBinder[i + loopCounter].rarity == 1)
                {
                    cardSlots[i].transform.GetChild(3).transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }
                if (sortedBinder[i + loopCounter].rarity == 2)
                {
                    cardSlots[i].transform.GetChild(3).transform.GetChild(1).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }
                if (sortedBinder[i + loopCounter].rarity == 3)
                {
                    cardSlots[i].transform.GetChild(3).transform.GetChild(2).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }
                if (sortedBinder[i + loopCounter].rarity == 4)
                {
                    cardSlots[i].transform.GetChild(3).transform.GetChild(3).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }
                if (sortedBinder[i + loopCounter].rarity == 5)
                {
                    cardSlots[i].transform.GetChild(3).transform.GetChild(4).GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }

                //Display Card Cost
                cardSlots[i].transform.GetChild(4).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i + loopCounter].cost.ToString();

                //Display Card Attack
                cardSlots[i].transform.GetChild(6).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i + loopCounter].attack.ToString();

                //Display Card Def
                cardSlots[i].transform.GetChild(7).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i + loopCounter].defense.ToString();

                //Display Card ACC
                cardSlots[i].transform.GetChild(8).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i + loopCounter].accuracy.ToString();

                //Display Card EVA
                cardSlots[i].transform.GetChild(9).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i + loopCounter].evasion.ToString();

                //Display Card HP
                cardSlots[i].transform.GetChild(10).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i + loopCounter].HP.ToString();

                //Display Card Range
                cardSlots[i].transform.GetChild(11).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i + loopCounter].range;

                //Display Card ATK PTRN
                cardSlots[i].transform.GetChild(12).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i + loopCounter].atkPatern;

                //Display # of ATKs
                cardSlots[i].transform.GetChild(13).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i + loopCounter].NumofATKs;

                //Display Type Tags

                //Display in form?
                //cardSlots[i].transform.GetChild(13).transform.GetChild(0).GetComponent<Text>().text = sortedBinder[i + loopCounter].inForm.ToString();

                //Set Array Pos
                cardSlots[i].transform.GetChild(16).transform.GetChild(1).GetComponent<Text>().text = (i + loopCounter).ToString();

                //get card rarity
                cardSlots[i].transform.GetChild(16).transform.GetChild(2).GetComponent<Text>().text = sortedBinder[i + loopCounter].rarity.ToString();

                //get card rarity
                cardSlots[i].transform.GetChild(16).transform.GetChild(3).GetComponent<Text>().text = sortedBinder[i + loopCounter].cardName;
            }

            for (int i = 0; i <= 9; i++)
            {
                if ((i + loopCounter) >= cardCount)
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
