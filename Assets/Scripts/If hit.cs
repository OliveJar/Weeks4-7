using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ifhit : MonoBehaviour
{
    public static bool isHit;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            score++;
            isHit = false;
        }
        scoreText.text = "Score: " + score;
    }
}
