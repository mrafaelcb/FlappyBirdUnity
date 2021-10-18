using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    Transform gameStart;

    [SerializeField]
    Transform player;

    [SerializeField]
    Text scoreText;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("FlappyBird");
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        gameStart.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(true);
    }
}
