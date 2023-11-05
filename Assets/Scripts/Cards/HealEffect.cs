using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "HealEffect", menuName = "Card Effect/Heal Effect")]
public class HealEffect : CardEffect
{
    public override void apply(Card card){

        int value = 0;
        switch (card.id)
        {

            case (2):
                value = 10;
                break;

            default:
                break;
        }

        //Inflict damage
        Character target = GameObject.Find("Game Manager").GetComponent<GameManager>().ActiveCharacter();
        target.AddHp(value);
        Debug.Log("Heal "+value+" HP!");
    }

}
