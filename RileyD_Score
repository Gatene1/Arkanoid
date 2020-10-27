using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RileyD_Score : MonoBehaviour{
    int score;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public int Score
    {
        get { return score; }
    }
    // Use this for initialization
    void Start()
    {
        score = 0;
    }
   
    public void scoreReset()
    {
        score = 0;
    }

    public void UpdateScore(int addend)
    {
        score += addend;
    }
    // Update is called once per frame
    void Update(){

    }
}
