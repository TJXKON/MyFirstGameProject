using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("Assignable data")]
    public CharacterData data;
    public PowerController powerController;
    public ActionController ActionController;
    public HpController hpController;

    [Space(15)]
    public int charId;
    public string charName;
    public int maxPower;
    public int maxHp;
    public string element;

    public int power;
    public int hp;

    public int action;
    public int quick;

    // Start is called before the first frame update
    void Start()
    {
        charId=data.charId;
        charName=data.charName;
        maxPower=data.maxPower;
        maxHp=data.maxHp;
        element=data.element;

    }

    // Update is called once per frame
    void Update()
    {
        powerController.power=power;
        powerController.maxPower=maxPower;
        ActionController.action=action;
        ActionController.quick=quick;
        hpController.maxHp=maxHp;
        hpController.hp=hp;
    }

    public void Initialize(){
        
        power=maxPower;
        hp=maxHp;
        action=1;
        quick=1;
    }

    public void ResetAction(){
        action=1;
        quick=1;
    }

    public void AddPower(int value){

        if ((power+value)>maxPower){
            power=maxPower;
        }
        else{
            power=power+value;
        }
    }

    public void AddHp(int value){
        if ((hp+value)>maxHp){
            hp=maxHp;
        }
        else{
            hp=hp+value;
        }
    }

    public int TakeDamage(int damage){

        int finalDamage = damage;
        //Calculation of final damage (pending)
        hp=hp-finalDamage;
        return finalDamage;
    }
}
