using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Random = UnityEngine.Random;

public class CardManager : MonoBehaviour
{
    //public int cardState; 하수인, 주문, 무기, 영웅변신

    //public string cardJob;  직업

    //public int cardLevel;  등급

    //public string cardTribe; // 종족

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

        int 확장팩 = Random.Range(0, 1);

        switch(확장팩)
        {
            case 0:
                
                break;
        }
    }
}
