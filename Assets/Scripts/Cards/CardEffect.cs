using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NoEffect", menuName = "Card Effect/No Effect")]

public class CardEffect : ScriptableObject {

     
    public virtual void apply(Card card){
        Debug.Log("No effect");
    }
}


