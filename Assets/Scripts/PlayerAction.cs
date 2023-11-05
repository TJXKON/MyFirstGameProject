using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAction : MonoBehaviour
{
    public GameManager gm;

    public GameObject[] buttons;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject button in buttons){
            if(gm.gameState==GameState.playerTurn){
                button.GetComponent<Button>().enabled = true;

            }else{
                
                button.GetComponent<Button>().enabled = false;

            }
        }


        
        
    }

    public void Rest(){
        Character character = gm.ActiveCharacter();
        if(character.action>0){
            character.AddPower(character.maxPower/2);
            character.action-=1;
        }else{
            Debug.Log("You need 1 action to rest");
        }
    }
    public void PlayCard(){

        GameObject cardObject = gm.activeCard;
        //Get the active character
        Character character = gm.ActiveCharacter();

        if (cardObject==null){
            Debug.Log("Please select a card");
            return;
        }
        Card card = cardObject.GetComponent<CardDetails>().card;
        //check cost
        if(card.cost>character.power){
            Debug.Log("Not enough power!");
            return;
        }
        //check quick
        if(card.isQuick=="y"){
            if(character.quick>0){
                character.quick-=1;
            }else if(character.action>0){
                character.action-=1;
            }else{
                Debug.Log("Not enough quick and action!");
                return;
            }
        }
        else if(character.action>0){
            character.action-=1;
        }else{
            Debug.Log("Not enough action!");
            return;
        }

        //consume cost
        character.power-=card.cost;

        gm.gameState = GameState.resolving;
        card.effect.apply(card);
        gm.Discard(gm.activeCard);
        gm.changeActiveCard(null);
        gm.gameState = GameState.playerTurn;

    }

    public void PlayerEndTurn(){
        gm.gameState=GameState.playerEnd;

    }
}
