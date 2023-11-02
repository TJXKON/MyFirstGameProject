using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardObject : MonoBehaviour
{
    public List<Card> card = new List<Card>();
    public int cardId;

    public int id;
    public string cardName;
    public int cost;
    public string isQuick;
    public string element;
    public string description;

    public Text nameText;
    public Text costText;
    public Text descriptionText;
    public Image baseColor;



    // Start is called before the first frame update
    void Start()
    {
        card.Add(CardDB.cardList[cardId]);
    }

    // Update is called once per frame
    void Update()
    {
        id = card[0].id;
        cardName = card[0].cardName;
        cost = card[0].cost;
        isQuick = card[0].isQuick;
        element = card[0].element;
        description = card[0].description;

        nameText.text = ""+cardName;
        costText.text = ""+cost;
        descriptionText.text = ""+description;
        switch (element)
        {
            case("n"):
                baseColor.GetComponent<Image>().color = new Color32(195,195,195,255);
                break;
            case("b"):
                baseColor.GetComponent<Image>().color = new Color32(217,225,242,255);
                break;
            default:
                break;
        }

    }
}
