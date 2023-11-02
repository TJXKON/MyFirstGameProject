using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Card",menuName="Card")]
public class Card: ScriptableObject
{
    public int id;
    public string cardName;
    public int cost;
    public string isQuick;
    public string element;
    public string description;

    [SerializeReference]public CardEffect effect;

    
    public Card(){

    }
    
    public Card(int _id,string _cardName,int _cost, string _isQuick, string _element, string _description){
        this.id=_id;
        this.cardName=_cardName;
        this.cost=_cost;
        this.isQuick=_isQuick;
        this.element=_element;
        this.description=_description;

    }



}
