using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Card Data", menuName = "Scriptable Object/Hearthstone", order = 1)]
public class CardData : ScriptableObject
{
    [Header("0 = Minion, 1 = Spell, 2 = Weapon, 3 = Place")]
    [SerializeField]
    private int cardState;

    public int CardState { get { return cardState; } }

    [Header("Warrior, Shaman, Rogue, Paladin, Hunter, Druid, Warlock, Mage, Priest, Demon Hunter, Nomal")]
    [SerializeField]
    private string cardJob;

    public string CardJob { get { return cardJob; } }

    [Header("0 = �Ϲ�, 1 = �ֱ�, 2 = ����, 3 = ����, 4 = ����")]
    [SerializeField]
    private int cardLevel;

    public int CardLevel { get { return cardLevel; } }

    [SerializeField]
    private string cardName;

    public string CardName { get { return cardName; }}


    [SerializeField]
    private int cost;

    public int Cost { get { return cost; }}


    [SerializeField]
    private int power;

    public int Power { get { return power; }}


    [SerializeField]
    private int hp;

    public int HP { get { return hp; }}


    [System.Serializable]
    public struct Keyword
    {
        public int ������;
        public bool ����;
        public bool ����;
        public bool ����;
        public bool �鿪;
        public bool �߰�;
        public bool ���;
        public bool ����;
        public bool ����������;
        public bool ����;
        public bool �Ӱ�;
        public bool ����;
        public bool ����;
        public bool �������Լ�;
        public int �ֹ����ݷ�;
        public bool �����Ǹ޾Ƹ�;
        public bool ��ǳ;
        public bool ����;
        public bool õ���Ǻ�ȣ��;
        public bool ħ��;
        public bool ����;
        public bool �߹���;
        public bool ����������;
        public int �޸�;
        public bool ����;
        public bool ��ȯ��;
        public bool ����Ʈ����;
        public bool �����ο��ϰ�;
        public int �ż�;
        public bool �ξ�;
        public int ����;
        public bool �����ǰ;
        public bool �ݷ�;
        public bool �����;
        public bool ����;
        public bool ����Ʈ����;
        public bool ����;
        public bool �ܻ�;
        public bool ��ü;
        public bool �л�;
        public bool �����ֹ�;
        public bool ����;
        public bool ȯ��;
        public bool ���;
        public bool �ΰ�����Ʈ����;
        public bool �ֹ�����;
        public bool Ÿ��;
    }

    [Header("Card Keyword")]
    public Keyword keyword;
}