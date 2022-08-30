using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Random = UnityEngine.Random;

public class CardManager : MonoBehaviour
{
    public string cardName; // 이름

    public int cardState; //하수인, 주문, 무기, 영웅변신

    public int cardJob; //직업

    public int cardCost; // 비용

    public int cardPower; // 공격력

    public int cardHp; // 체력

    //public int cardLevel; //등급

    //public string cardTribe; // 종족

    public GameObject clone;


    public GameObject[] cardDatas1 = new GameObject[0];


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RandomCardShuffle()
    {
        Destroy(clone);

        int DLC = Random.Range(0, 1);

        switch(DLC)
        {
            case 0:
                while(true)
                {
                    Debug.Log("시작");

                    int random = Random.Range(0, cardDatas1.Length);

                    clone = Instantiate(cardDatas1[random]);

                    Card temple = clone.GetComponent<Card>();

                    if (temple.cardStateCondition == cardState || cardState < 0)
                    {
                        if (temple.cardJobCondition == cardJob || cardJob < 0)
                        {
                            if (temple.cardCostCondition == cardCost || cardCost < 0)
                            {
                                if (temple.cardPowerCondition == cardPower || cardPower < 0)
                                {
                                    if (temple.cardHpCondition == cardHp || cardHp < 0)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Destroy(clone);
                                    }
                                    break;
                                }
                                else
                                {
                                    Destroy(clone);
                                }
                            }
                            else
                            {
                                Destroy(clone);
                            }
                        }
                        else
                        {
                            Destroy(clone);
                        }
                    }
                    else
                    {
                        Destroy(clone);
                    }
                }
                break;
        }
    }

    public void CardCostMask()
    {

    }
}
