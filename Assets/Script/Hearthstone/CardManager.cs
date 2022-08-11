using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public int cardStateCondition;

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

                    if (cardStateCondition == 가라앉은도시로의항해[random].transform.gameObject.GetComponent<CardData>().CardState)
                    {
                        
                        break;
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
