using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class editFormUI : MonoBehaviour
{
    public GameObject[] formSlots;
    public GameObject[] cards;
    private int userCards;
    public Text formName;
    public Text formATK;
    public Text formDEF;
    public Text formCost;


    void showUserCards()
    {
        userCards = playerCards.userCards.Count;

        for (int i = 0; i < cards.Length; i++)
        {
            if(i < userCards)
            {
                //Get image, range, atk, def, cost
                cards[i].transform.GetComponent<Image>().sprite = playerCards.userCards[i].cardArt;
                cards[i].transform.GetChild(1).GetComponent<Text>().text = playerCards.userCards[i].range;
                cards[i].transform.GetChild(6).GetComponent<Text>().text = playerCards.userCards[i].attack.ToString();
                cards[i].transform.GetChild(7).GetComponent<Text>().text = playerCards.userCards[i].defense.ToString();
                cards[i].transform.GetChild(8).GetComponent<Text>().text = playerCards.userCards[i].cost.ToString();
            }
            else
            {
                cards[i].gameObject.SetActive(false);
            }

            /**
            cards[i].transform.GetComponent<Image>().sprite = playerCards.userCards[i].cardArt;
            cards[i].transform.GetChild(1).GetComponent<Text>().text = playerCards.userCards[i].range;
            cards[i].transform.GetChild(6).GetComponent<Text>().text = playerCards.userCards[i].attack.ToString();
            cards[i].transform.GetChild(7).GetComponent<Text>().text = playerCards.userCards[i].defense.ToString();
            cards[i].transform.GetChild(8).GetComponent<Text>().text = playerCards.userCards[i].cost.ToString();
            **/
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //test cards
        playerCards.userCards = Resources.LoadAll<Card>("Prefabs/test").ToList();
        print(playerCards.userCards.Count);
        showUserCards();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
