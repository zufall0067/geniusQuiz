using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Random = UnityEngine.Random;

public class CardManager : MonoBehaviour
{
    public string cardName; // �̸�

    public int cardState; //�ϼ���, �ֹ�, ����, ��������

    public string cardJob; //����

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

        int Ȯ���� = Random.Range(0, 1);

        switch(Ȯ����)
        {
            case 0:
                while(true)
                {

                }
                break;
        }
    }
}
