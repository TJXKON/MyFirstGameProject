using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpController : MonoBehaviour
{
    public int hp;
    public int maxHp;
    public Text hpText;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = "HP: "+hp+"/"+maxHp;
    }
}
