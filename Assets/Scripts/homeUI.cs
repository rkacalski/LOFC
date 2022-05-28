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
    public List<Card> newCardBinder = new List<Card>();

    public void questButton()
    {
        SceneManager.LoadScene("tradeBlock");
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
        playerInv = playerCards.userCards.Count;

        if (playerInv == 0)
        {
            for(int i = 0; i < newCardBinder.Count; i++)
            {
                playerCards.userCards.Add(newCardBinder[i]);
            }
            
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

    public void hanger()
    {
        SceneManager.LoadScene("Hanger");
    }

    // Start is called before the first frame update
    void Start()
    {
        addStarterCards();
        check = 1;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
