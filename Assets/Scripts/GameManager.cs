using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject _gameOverCanvas;

    private void Awake(){
        if(instance == null){
            instance = this;
        }
        Time.timeScale = 1f;//to make the game run after game over again
    }
    public void GameOver(){
        _gameOverCanvas.SetActive(true);//by default it is disabled(false) if player lose show game over canvas 
        Time.timeScale = 0f;//turn of the game
    }
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//when lose and click restart button load the same scene again
    }
}
