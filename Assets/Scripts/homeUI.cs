using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class homeUI : MonoBehaviour
{
    public GameObject Image;
    public int check;
    public int playerInv;

    public void questButton()
    {
        SceneManager.LoadScene("questTest");
    }

    public void battleButton()
    {
        SceneManager.LoadScene("endor_6.6_N");
    }

    public void cardButton()
    {
        print(check);
        check = 1;
        if(check != 0)
        {
            Image.transform.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
            check = 0;
        }
    }

    public void operationsButton()
    {

    }

    public void allyButton()
    {

    }

    public void chatButton()
    {

    }

    public void addStarterCards()
    {
        Card tempCard;
        List<Card> tempBinder = new List<Card>();
        playerInv = playerCards.userCards.Count;

        if (playerInv == 0)
        {
            tempBinder = Resources.LoadAll<Card>("Prefabs/1Star/Base").ToList();

            for(int i = 0; i < tempBinder.Count; i++)
            {
                tempCard = GameObject.Instantiate(tempBinder[i]);
                playerCards.userCards.Add(tempCard);
            }

            tempBinder = Resources.LoadAll<Card>("Prefabs/1Star/evomax").ToList();

            for (int i = 0; i < tempBinder.Count; i++)
            {
                tempCard = GameObject.Instantiate(tempBinder[i]);
                playerCards.userCards.Add(tempCard);
                playerCards.userCards.Add(tempCard);
            }

            tempBinder = Resources.LoadAll<Card>("Prefabs/2 Star/Base").ToList();

            for (int i = 0; i < tempBinder.Count; i++)
            {
                tempCard = GameObject.Instantiate(tempBinder[i]);
                playerCards.userCards.Add(tempCard);
            }

            tempBinder = Resources.LoadAll<Card>("Prefabs/5 Star/Base").ToList();

            for (int i = 0; i < tempBinder.Count; i++)
            {
                tempCard = GameObject.Instantiate(tempBinder[i]);
                playerCards.userCards.Add(tempCard);
                playerCards.userCards.Add(tempCard);
            }

            //print(playerCards.userCards.Count);
            playerCards.userCards = playerCards.userCards.OrderBy(x => x.rarity).ToList();
            playerCards.userCards.Reverse();
        }
        playerInv = 1;
    }

    //Enhance Button
    public void enhance()
    {
        SceneManager.LoadScene("enhanceCardMain");
    }

    public void skillMast()
    {
        SceneManager.LoadScene("skillMastMain");
    }

    public void evolve()
    {
        SceneManager.LoadScene("evoHome");
    }

    public void awaken()
    {
        SceneManager.LoadScene("awakenHome");
    }

    public void cardBinder()
    {
        SceneManager.LoadScene("Card Binder");
    }

    // Start is called before the first frame update
    void Start()
    {
        addStarterCards();
        check = 1;

        //test
        string test1;
        test1 = "gg[AE]_5star_evo1";

        for (int i = 0; i < playerCards.userCards.Count; i++)
        {
            if(playerCards.userCards[i].cardName.Equals(test1))
            {
                print(playerCards.userCards[i].cardName);
                print(playerCards.userCards[i].baseSkillLevel);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
