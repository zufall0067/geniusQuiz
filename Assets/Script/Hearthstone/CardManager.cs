using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Random = UnityEngine.Random;

public class CardManager : MonoBehaviour
{
    public string cardName; // �̸�

    public int cardState; //�ϼ���, �ֹ�, ����, ��������

    public int cardJob; //����

    public int cardCost; // ���

    public int cardPower; // ���ݷ�

    public int cardHp; // ü��

    //public int cardLevel; //���

    //public string cardTribe; // ����

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
                    Debug.Log("����");

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
