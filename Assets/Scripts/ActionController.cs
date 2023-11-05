using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionController : MonoBehaviour
{

    public int action = 0;
    public int quick = 0;
    public Text actionText;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        actionText.text = "Action: "+action+", Quick: "+quick;
    }


}
