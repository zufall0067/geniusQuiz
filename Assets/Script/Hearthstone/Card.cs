using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enum CardLevel
//{
//    ÀÏ¹Ý = 0,
//    ÈÖ±Í,
//    ¿µ¿õ,
//    Àü¼³,
//    ¾øÀ½
//};

public class Card : MonoBehaviour
{
    public CardData cardData;

    public int cardStateCondition;

    public int cardJobCondition;

    public int cardCostCondition;

    public int cardPowerCondition;

    public int cardHpCondition;


    //public int cardLevelCondition;

    //public string cardTribeCondition;


    private void Awake()
    {
        cardStateCondition = (int)cardData.cardState;
        cardJobCondition = (int)cardData.cardJob;
        cardCostCondition = cardData.Cost;
        cardHpCondition = cardData.HP;
        cardPowerCondition = cardData.Power;
        //cardLevelCondition = cardData.CardLevel;
        //cardTribeCondition = cardData.CardTribe;
    }

    void Update()
    {
        
    }
}
