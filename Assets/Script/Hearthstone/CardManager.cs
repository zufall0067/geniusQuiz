using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Random = UnityEngine.Random;

public class CardManager : MonoBehaviour
{
    public string cardName; // 이름

    public int cardState; //하수인, 주문, 무기, 영웅변신

    public string cardJob; //직업

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

        int 확장팩 = Random.Range(0, 1);

        switch(확장팩)
        {
            case 0:
                while(true)
                {

                }
                break;
        }
    }
}
