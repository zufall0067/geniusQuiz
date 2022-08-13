using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public int cardState; //하수인, 주문, 무기, 영웅변신

    public string cardJob; // 직업

    public int cardLevel; // 등급

    public string cardTribe; // 종족

    public GameObject clone;

    public GameObject[] 가라앉은도시로의항해;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RandomCardSuch()
    {
        Destroy(clone);

        int 확장팩 = Random.Range(0, 1);

        switch(확장팩)
        {
            case 0:
                while(true)
                {
                    int random = Random.Range(0, 가라앉은도시로의항해.Length);

                    clone = Instantiate(가라앉은도시로의항해[random]);

                    Card temple = clone.GetComponent<Card>();

                    if (temple.cardStateCondition == cardState || cardState < 0)
                    {
                        if(temple.cardJobCondition == cardJob || cardJob == " ")
                        {
                            if (temple.cardLevelCondition == cardLevel || cardLevel < 0)
                            {
                                if(temple.cardTribeCondition == cardTribe || cardTribe == " ")
                                {
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
}
