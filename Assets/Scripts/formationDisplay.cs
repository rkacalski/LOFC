using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class formationDisplay : MonoBehaviour
{
    public GameObject[] formSlots;
    public Text formName;
    public Text formBattleStrength;
    public Text formATK;
    public Text formDEF;
    public Text formCost;

    public void formtest()
    {
        playerCards.userCards = Resources.LoadAll<Card>("Prefabs/1Star/Base").ToList();
        print(playerCards.userCards.Count);
    }

    void Start()
    {
        formtest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
