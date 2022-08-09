using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card Data", menuName = "Scriptable Object/Hearthstone", order = 1)]
public class CardData : ScriptableObject
{
    [Header("Minion, Spell, Weapon, Place")]
    [SerializeField]
    private int cardState;

    public int CardState { get { return cardState; } }

    [Header("Warrior, Shaman, Rogue, Paladin, Hunter, Druid, Warlock, Mage, Priest, Demon Hunter")]
    [SerializeField]
    private string cardJob;

    public string CardJob { get { return cardJob; } } 


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

    }
}
