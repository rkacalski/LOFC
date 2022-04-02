using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wishlistUI : MonoBehaviour
{
    public CardBinder cardbinder;
    public GameObject[] cardSlots;

    List<Card> sortedBinder = new List<Card>();
    public Card tempCard;

    int currentBinder;
    public int cardCount;
    public int loopCounter;
    public int pageNum;
    public float pageMax;
    public Text pageText;

    // Start is called before the first frame update
    void Start()
    {
        currentBinder = wishlistDropDown.chosenOption;
        DisplayCards(currentBinder);
        pageNum = 1;
        pageText.text = pageNum+ "/" + pageMax;
    }

    void Update()
    {
        currentBinder = wishlistDropDown.chosenOption;
        updatePage();
        updateCards(currentBinder);
    }

    public void updatePage()
    {
        pageText.text = pageNum + "/" + pageMax;
    }

    public void nextPage()
    {
        if (cardCount > 0)
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
        if (cardCount > 0)
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

    public int getcardAmount(int selectedBinder)
    {
        if(selectedBinder.Equals(0))
        {
            cardCount = cardbinder.oneStarbaseLight.Count;
            return cardCount;
        }
        if (selectedBinder.Equals(1))
        {
            cardCount = cardbinder.oneStarbaseDark.Count;
            return cardCount;
        }
        if (selectedBinder.Equals(2))
        {
            cardCount = cardbinder.oneStarbaseNuet.Count;
            return cardCount;
        }
        return -1;
    }

    private void DisplayCards(int selectedBinder)
    {
        if(selectedBinder.Equals(0))
        {
            sortedBinder = cardbinder.oneStarbaseLight;
        }
        if (selectedBinder.Equals(1))
        {
            sortedBinder = cardbinder.oneStarbaseDark;
        }
        if (selectedBinder.Equals(2))
        {
            sortedBinder = cardbinder.oneStarbaseNuet;
        }

        cardCount = getcardAmount(selectedBinder);
        pageMax = Mathf.Ceil(sortedBinder.Count / 10f);

        if(sortedBinder.Count > 1)
        {
            tempCard = sortedBinder[0];
        }

        for (int i = 0; i <= 9; i++)
        {
            if (i <= cardCount - 1)
            {
                cardSlots[i].gameObject.SetActive(true);

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
                cardSlots[i].transform.GetChild(16).transform.GetChild(4).GetComponent<Text>().text = i.ToString();
            }
            if (i > cardCount - 1)
            {
                cardSlots[i].gameObject.SetActive(false);
            }
        }
    }

    private void updateCards(int selectedBinder)
    {
        if (currentBinder != selectedBinder)
        {
            pageNum = 1;
        }
        if (selectedBinder.Equals(0))
        {
            sortedBinder = cardbinder.oneStarbaseLight;
        }
        if (selectedBinder.Equals(1))
        {
            sortedBinder = cardbinder.oneStarbaseDark;
        }
        if (selectedBinder.Equals(2))
        {
            sortedBinder = cardbinder.oneStarbaseNuet;
        }

        if(!sortedBinder[0].cardName.Equals(tempCard.cardName))
        {
            pageNum = 1;
        }

        if (pageNum == 1)
        {
            for (int i = 0; i <= 9; i++)
            {
                cardSlots[i].gameObject.SetActive(true);
            }
            DisplayCards(selectedBinder);
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

                //set orig array pos
                cardSlots[i].transform.GetChild(16).transform.GetChild(4).GetComponent<Text>().text = (i + loopCounter).ToString();
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
