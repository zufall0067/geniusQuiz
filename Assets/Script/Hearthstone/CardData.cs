using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Card Data", menuName = "Scriptable Object/Hearthstone", order = 1)]
public class CardData : ScriptableObject
{
    [Header("0 = Minion, 1 = Spell, 2 = Weapon, 3 = Place, 4 = 영웅변신")]
    public CardState cardState;

    [Header("Warrior, Shaman, Rogue, Paladin, Hunter, Druid, Warlock, Mage, Priest, Demon Hunter, Nomal")]
    public CardJob cardJob;

    //[Header("0 = 일반, 1 = 휘귀, 2 = 영웅, 3 = 전설, 4 = 없음")]
    //public CardLevel cardLevel;

    //[Header("Murloc, Demon, Beast, Dragon, Totem, Pirate, Machine, Elemental, QuillBoar, Naga, All")]
    //public CardTribe cardTribe;

    //[Header("Frost, Arcane, Holy, Fire, Shadow, Fel, Nature")]
    //public CardSpellTribe cardSpellTribe;

    [Space(10f)]
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


    /*[System.Serializable]
    public struct Keyword
    {
        public int 과부하;
        public bool 도발;
        public bool 독성;
        public bool 돌진;
        public bool 면역;
        public bool 발견;
        public bool 비밀;
        public bool 빙결;
        public bool 생명력흡수;
        public bool 선택;
        public bool 속공;
        public bool 연계;
        public bool 은신;
        public bool 전투의함성;
        public int 주문공격력;
        public bool 죽음의메아리;
        public bool 질풍;
        public bool 차단;
        public bool 천상의보호막;
        public bool 침묵;
        public bool 개전;
        public bool 추방자;
        public bool 뽑을때시전;
        public int 휴면;
        public bool 광폭;
        public bool 교환성;
        public bool 퀘스트전개;
        public bool 명예로운일격;
        public int 거수;
        public bool 인양;
        public int 주입;
        public bool 예비부품;
        public bool 격려;
        public bool 비취골렘;
        public bool 적응;
        public bool 퀘스트보상;
        public bool 소집;
        public bool 잔상;
        public bool 합체;
        public bool 압살;
        public bool 이중주문;
        public bool 졸개;
        public bool 환생;
        public bool 기원;
        public bool 부가퀘스트보상;
        public bool 주문폭주;
        public bool 타락;
    }*/

    [Header("Card Keyword")]
    public List<CardKeyword> keyword = new List<CardKeyword>();
}
