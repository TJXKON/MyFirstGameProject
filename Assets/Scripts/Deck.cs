using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    public List<int> cardList = new List<int>();

    public int deckNum;

    public Text deckText;
    

    // Start is called before the first frame update
    void Start()
    {
        //Resources.Load<Card>("Cards/card1")
        //Initialize deck (for testing)
        for (int i=0;i<4;i++){
            cardList.Add(1);
            cardList.Add(3);
            if (i>=2){
                cardList.Add(2);
            }
        }
        Debug.Log("Deck created successful");
        
    }

    // Update is called once per frame
    void Update()
    {
        deckNum = cardList.Count;
        deckText.text=""+deckNum;
    }

    public void Shuffle(){
        
        for (int i=0;i<cardList.Count;i++){
            int j = Random.Range(0,cardList.Count);
            int temp = cardList[i];
            cardList[i] = cardList[j];
            cardList[j] = temp;
        }
        Debug.Log("Deck shuffled");
    }
}
