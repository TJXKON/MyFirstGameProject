using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscardPile : MonoBehaviour
{
    public List<int> cardList = new List<int>();

    public int discardNum;

    public Text discardText;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        discardNum = cardList.Count;
        discardText.text=""+discardNum;
    }

}
