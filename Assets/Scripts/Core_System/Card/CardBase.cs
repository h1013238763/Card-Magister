using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card Base", menuName = "Card Magister/CardBase", order = 0)]
public class CardBase : ScriptableObject
{
    public string card_id;
    public int card_tier;
    public int card_rare;
    public int card_cold;
    public int card_cost;
    public string card_name;
    [TextArea]
    public string card_describe;
}

public enum CardType
{
    Material,
    Unit,
    Gear,
    Magic,
    Curse,
    Ceremony,
    Ground
}

public enum CardTag
{
    melee,
    ranged,
    animal
}