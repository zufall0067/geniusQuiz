using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public int cardState; //�ϼ���, �ֹ�, ����, ��������

    public string cardJob; // ����

    public int cardLevel; // ���

    public string cardTribe; // ����

    public GameObject clone;

    public GameObject[] ����������÷�������;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void RandomCardSuch()
    {
        Destroy(clone);

        int Ȯ���� = Random.Range(0, 1);

        switch(Ȯ����)
        {
            case 0:
                while(true)
                {
                    int random = Random.Range(0, ����������÷�������.Length);

                    clone = Instantiate(����������÷�������[random]);

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
