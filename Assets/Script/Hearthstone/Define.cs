using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define : MonoBehaviour
{
}
public enum CardState
{
    Minion,
    Spell,
    Weapon,
    Place,
    HeroChange
};

public enum CardJob
{
    Warrior, 
    Shaman, 
    Rogue, 
    Paladin, 
    Hunter, 
    Druid, 
    Warlock, 
    Mage, 
    Priest, 
    DemonHunter, 
    Nomal
};

public enum CardLevel
{
    Normal,
    Rare, 
    Epic,
    Legend, 
    None
}

public enum CardTribe
{
    None,
    Murloc, 
    Demon, 
    Beast, 
    Dragon, 
    Totem, 
    Pirate, 
    Machine, 
    Elemental, 
    QuillBoar, 
    Naga, 
    All
};

public enum CardSpellTribe
{
    Frost, 
    Arcane, 
    Holy, 
    Fire, 
    Shadow, 
    Fel, 
    Nature
}

public enum CardKeyword
{
    과부하,
    도발,
    독성,
    돌진,
    면역,
    발견,
    비밀,
    빙결,
    생명력흡수,
    선택,
    속공,
    연계,
    은신,
    전투의함성,
    주문공격력,
    죽음의메아리,
    질풍,
    차단,
    천상의보호막,
    침묵,
    개전,
    추방자,
    뽑을때시전,
    휴면,
    광폭,
    교환성,
    퀘스트전개,
    명예로운일격,
    거수,
    인양,
    주입,
    예비부품,
    격려,
    비취골렘,
    적응,
    퀘스트보상,
    소집,
    잔상,
    합체,
    압살,
    이중주문,
    졸개,
    환생,
    기원,
    부가퀘스트보상,
    주문폭주,
    타락
};
