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

    public string cardJobCondition;

    public int cardLevelCondition;

    public string cardTribeCondition;


    private void Awake()
    {
        //cardStateCondition = cardData.CardState;
        //cardJobCondition = cardData.CardJob;
        //cardLevelCondition = cardData.CardLevel;
        //cardTribeCondition = cardData.CardTribe;
    }

    void Update()
    {
        
    }
}
