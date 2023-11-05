using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    startGame,
    playerStart,
    playerTurn,
    resolving,
    playerEnd,
    enemyStart,
    enemyTurn,
    enemyEnd,
    enemyClear
}
public class GameManager : MonoBehaviour
{
    public Deck deck;
    public GameObject handCards;

    public DiscardPile discardPile;

    public Character[] characters;

    public GameObject cardPrefab;

    public GameState gameState;

    public GameObject activeCard;


    // Start is called before the first frame update
    void Start()
    {
        //Setup
        deck = GameObject.Find("Deck").GetComponent<Deck>();
        handCards=GameObject.Find("HandCards");
        discardPile=GameObject.Find("DiscardPile").GetComponent<DiscardPile>();
        characters = GameObject.Find("CharacterContainer").GetComponentsInChildren<Character>();
        /**
        foreach (Character c in characters)
        {
            Debug.Log(c.charName);
        }
*/
        GameStart();
 
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case (GameState.playerStart):
                PlayerStart();
                break;
            
            case (GameState.playerEnd):
                EndTurn();
                break;
            
            default:
                break;
        }
    }

    void GameStart(){

        gameState = GameState.startGame;
        //Shuffle deck
        deck.Shuffle();
        Draw(4);

        foreach (Character c in characters)
        {
            c.Initialize();
        }

        gameState=GameState.playerStart;

    }

    public void PlayerStart(){
        gameState=GameState.playerStart;

        foreach (Character c in characters)
        {
            c.ResetAction();
        }

        Draw(1);

        gameState=GameState.playerTurn;
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
                Discard(cardObject);
            }

            //cardObject.GetComponent<CardDetails>().card.effect.perform();
         }
        

    }

    void RefillDeck(){
        for(int i=0 ;i<discardPile.cardList.Count;i++){
            deck.cardList.Add(discardPile.cardList[i]);
        }
        discardPile.cardList.Clear();
        deck.Shuffle();
    }

    public Character ActiveCharacter(){

        //test
        return characters[0]; 
    }

    public void changeActiveCard(GameObject cardObject){
        if(activeCard!=null){
            activeCard.GetComponent<CardDetails>().isActive=false;
        }
        if(cardObject==null){
            activeCard=null;
            return;
        }
        cardObject.GetComponent<CardDetails>().isActive=true;
        activeCard=cardObject;
    }

    public void Discard(GameObject cardObject){
        discardPile.cardList.Add(cardObject.GetComponent<CardDetails>().card.id);
        Destroy(cardObject);
    }

    public void EndTurn(){
        Debug.Log("End TUrn");

        //gameState = GameState.enemyStart;
        gameState=GameState.enemyStart;
    }

}
