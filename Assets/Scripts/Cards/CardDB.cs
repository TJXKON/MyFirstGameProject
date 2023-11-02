using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDB : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();


    void Awake() {
        cardList.Add(new Card(0,"Dummy",0,"n","n","None"));
        cardList.Add(new Card(1,"Normal attack",1,"n","n","Deal 5 damage"));
        cardList.Add(new Card(2,"Heal",2,"n","n","Heal 10 HP"));
        cardList.Add(new Card(3,"Quick Attack",1,"y","n","Deal 3 damage"));

        //Debug
        CardListLog();
    }


    void CardListLog(){
        foreach (Card card in cardList){
            Debug.Log("Add Card id:"+card.id.ToString()+" , "+card.cardName);
        }
    }
}
