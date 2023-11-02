 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class CardDetails : MonoBehaviour
{
    public Card card;

    public Text nameText;
    public Text costText;
    public Text descriptionText;
    public Image baseColor;



    // Start is called before the first frame update
    void Start()
    {

        nameText.text = ""+card.cardName;
        costText.text = ""+card.cost;
        descriptionText.text = ""+card.description;
        switch (card.element)
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

    // Update is called once per frame
    void Update()
    {


    }

}
