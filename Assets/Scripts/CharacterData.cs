using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CharacterData", menuName = "Character Data")]
public class CharacterData : ScriptableObject {
    
    public int charId;
    public string charName;
    public int maxPower;
    public int maxHp;
    public string element;

}
