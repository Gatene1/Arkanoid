using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RileyD_ScoreText : MonoBehaviour
{

    Text scoreText;
    RileyD_Score getScore;
    string precZeroes;
    
    // Use this for initialization
    void Start()
    {
        scoreText = gameObject.GetComponentInChildren<Text>();
        getScore = GameObject.FindObjectOfType<RileyD_Score>();
    }

    // Update is called once per frame
    void Update()
    {
        int scorePrep = getScore.Score;
        if (scorePrep == 0)
            precZeroes = "0000000";
        else if (scorePrep < 1000)
            precZeroes = "0000";
        else if (scorePrep < 10000)
            precZeroes = "000";
        scoreText.text = "Score: " + precZeroes + scorePrep;
    }
}
