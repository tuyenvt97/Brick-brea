using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public static GameController Instance = null;

    public GameObject pnlEndGame;
    public Text textEndPoint;
    public Button btnRestart;

    private void Awake()
    {
        Debug.Log(GameState.instance.brickcout);
        Instance = this;
    }

    public void Start()
    {
        pnlEndGame.SetActive(false);
    }

    public void EndGame1()
    {
        pnlEndGame.SetActive(true);
        textEndPoint.text = "Your point\n" + GameState.instance.brickcout;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("test");
        Time.timeScale = 1;
    }

    public void Restart()
    {
        StartGame();
    }
}

class GameState
{
    public int brickcout = 9;
    public static GameState instance = new GameState();

    private GameState() { }
}