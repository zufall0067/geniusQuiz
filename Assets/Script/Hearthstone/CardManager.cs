using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    //public int cardState; �ϼ���, �ֹ�, ����, ��������

    //public string cardJob;  ����

    //public int cardLevel;  ���

    //public string cardTribe; // ����

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
                
                break;
        }
    }
}
