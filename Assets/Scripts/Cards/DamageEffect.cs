using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DamageEffect", menuName = "Card Effect/Damage Effect")]
public class DamageEffect : CardEffect
{
    public override void perform(){
        Debug.Log("Deal N damage");
    }

}
