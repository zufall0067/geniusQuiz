using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public int cardStateCondition;

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

                    if (cardStateCondition == ����������÷�������[random].transform.gameObject.GetComponent<CardData>().CardState)
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
