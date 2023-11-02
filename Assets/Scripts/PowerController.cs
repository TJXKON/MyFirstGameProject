using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerController : MonoBehaviour
{

    public int power;
    public int maxPower;
    public Text powerText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        powerText.text = "Power: "+power+"/"+maxPower;
    }

    public void RefillAll(){
        power = maxPower;
    }
}
