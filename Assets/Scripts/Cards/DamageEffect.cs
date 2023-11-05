using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DamageEffect", menuName = "Card Effect/Damage Effect")]
public class DamageEffect : CardEffect
{
    public override void apply(Card card){

        int damage = 0;
        switch (card.id)
        {

            case (1):
                damage = 5;
                break;
            case (3):
                damage = 3;
                break;
            default:
                break;
        }

        //Inflict damage
        Enemy enemy = GameObject.Find("Enemy").GetComponent<Enemy>();
        int finalDamage = enemy.TakeDamage(damage);
        Debug.Log("Deal "+finalDamage+" damage!");
    }

}
