using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enum CardLevel
//{
//    �Ϲ� = 0,
//    �ֱ�,
//    ����,
//    ����,
//    ����
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
