using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState { playing, won, lost };
public class L1Manager : MonoBehaviour
{
    public static L1Manager S;
    private GameState gameState;

    public AudioClip failure;
    public AudioClip win;

    public GameObject Failuretip;

    UIController UI;

    void Awake()
    {
        S = this;
        gameState = GameState.playing;
        Failuretip.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState == GameState.lost)
        {
            UI.TimeCountDown.text = "Game Over";
            Failuretip.gameObject.SetActive(true);
        }
        if (gameState == GameState.won)
        {
            AudioSource.PlayClipAtPoint(win, transform.position);
        }
    }

    public void SetGameWin()
    {
        //Time.timeScale = 1.0f;
        gameState = GameState.won;
    }
    public void SetGameOver()
    {
        //Time.timeScale = 0.0f;
        gameState = GameState.lost;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            RemainingLife.Instance.LoseLife();
        }
    }
}
