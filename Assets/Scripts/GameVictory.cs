using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class GameVictory : MonoBehaviour
{
    public GameObject Victory;

    public float time = 20f;

    public TextMeshProUGUI text;
    public Score sc;
    private double total;
    public GameManager gameManager;

    void Start()
    {
        sc = GameObject.FindObjectOfType<Score>().GetComponent<Score>();
        gameManager = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
    }

    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            VictoryGame();

        }
        if (time > 0 && gameManager.checkPause == false) Time.timeScale = 1;

    }
    private void VictoryGame()
    {
        total = sc.score;
        Time.timeScale = 0;
        Victory.SetActive(true);
        ShowTotal();

    }
    private void ShowTotal()
    {
        text.text = "Total: " + total;
    }
}
