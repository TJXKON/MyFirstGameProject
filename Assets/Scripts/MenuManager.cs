using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool GameIsOver = false;


    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject victoryMenu;
    [SerializeField] private GameObject gameOverMenu; 
    // Start is called before the first frame update
    void Start()
    {
        GameIsPaused = false;
        GameIsOver = false;
        pauseMenu.SetActive(false);
        victoryMenu.SetActive(false);
        gameOverMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&&!GameIsOver){
            if(GameIsPaused){
                Resume();
            }else{
                Pause();
            }
        }
    }

    void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume(){
        Time.timeScale = 1f;
        GameIsPaused = false;
        pauseMenu.SetActive(false);
    }

    public void Restart(){
        //Restart game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit(){
        Debug.Log("Exit the game");
        Application.Quit();
    }

    public void Victory(){
        victoryMenu.SetActive(true);
        GameIsOver = true;
        Time.timeScale = 0f;
    }

    public void GameOver(){
        gameOverMenu.SetActive(true);
        GameIsOver = true;
        Time.timeScale = 0f;
    }

}
