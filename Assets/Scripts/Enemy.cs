using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    public int hp;
    public int maxHp = 20;
    public Text hpText;
    private GameManager gm;


    public Character[] characters;
    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();


    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = "HP: "+hp+"/"+maxHp;
        switch (gm.gameState)
        {
            case(GameState.enemyStart):
                gm.gameState=GameState.enemyTurn;
                Action();
                break;
            case(GameState.enemyEnd):
                gm.gameState=GameState.playerStart;
                break;
            default:
                break;
        }
        if(hp<=0){
            Defeat();
        }

    }
    void Action(){
        //Determine which action
        Attack();
        gm.gameState=GameState.enemyEnd;
    }

    void Attack(){
        //Random damage
        int damage = Random.Range(3,7);

        //Update characters
        characters = gm.characters;

        //Get target (test)
        Character target = characters[0];
        int finalDamage = target.TakeDamage(damage);
    }

    public int TakeDamage(int damage){

        int finalDamage = damage;
        //Calculation of final damage (pending)
        hp=hp-finalDamage;
        if(hp<0){
            hp=0;
        }
        this.gameObject.GetComponent<FlashController>().Flash();
        return finalDamage;
    }

    void Defeat(){
        gm.gameState = GameState.enemyClear;
        Destroy(this.gameObject,0.25f);
    }


}
