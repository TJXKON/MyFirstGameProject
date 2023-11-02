using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NoEffect", menuName = "Card Effect/No Effect")]

public class CardEffect : ScriptableObject {
    public virtual void perform(){
        Debug.Log("No effect");
    }
}


