using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Random = UnityEngine.Random;

public class CardManager : MonoBehaviour
{
    //public int cardState; �ϼ���, �ֹ�, ����, ��������

    //public string cardJob;  ����

    //public int cardLevel;  ���

    //public string cardTribe; // ����

    public GameObject clone;

    public IEnumerable<CardData> cardDatas;

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
                
                break;
        }
    }
}
