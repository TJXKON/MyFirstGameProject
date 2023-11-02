using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    startGame,
    playerStart,
    playerAction,
    resolving,
    playerEnd,
    enemyAction
}
public class GameManager : MonoBehaviour
{
    public Deck deck;
    public GameObject handCards;

    public GameObject power;

    public GameObject cardPrefab;

    public GameState gameState;


    // Start is called before the first frame update
    void Start()
    {
        //Initialize items
        deck = GameObject.Find("Deck").GetComponent<Deck>();
        handCards=GameObject.Find("HandCards");
        power=GameObject.Find("Power");

            GameStart();



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameStart(){

        gameState = GameState.startGame;
        //Shuffle deck
        deck.Shuffle();
        //Initialize Power
        power.GetComponent<PowerController>().RefillAll();
        //Draw 5 cards
        Draw(5);
    }

    void Draw(int num){
        
        for(int i=0;i<num;i++){

            if (deck.cardList.Count==0){
                RefillDeck();
            }

            //Add card object
            int id = deck.cardList[0];
            Card card = Resources.Load<Card>("Cards/card_"+id);
            GameObject cardObject = Instantiate(cardPrefab,handCards.transform);
            cardObject.GetComponent<CardDetails>().card=card;

            deck.cardList.RemoveAt(0);

            if(handCards.transform.childCount>7){
                Destroy(cardObject);
            }

            cardObject.GetComponent<CardDetails>().card.effect.perform();
         }
        

    }

    void RefillDeck(){
        
    }



}
