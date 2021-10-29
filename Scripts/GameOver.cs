using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static string finalString = "Game Over \n Your score is: ";
    Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        gameOverText.text = finalString + ScoreScript.scoreValue;
    }
}
