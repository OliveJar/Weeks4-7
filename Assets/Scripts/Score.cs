using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    //Declare variables
    public static bool isHit;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    // Update is called once per frame
    void Update()
    {
        //Checks to see if enemy was hit
        if (isHit)
        {
            //increase score
            score++;
            isHit = false;
        }
        //Update score text to score
        scoreText.text = "Score: " + score;
    }
}
