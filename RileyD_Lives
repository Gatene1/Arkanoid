using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RileyD_Lives : MonoBehaviour {

    int lives;
    RileyD_LevelManager levelManager;
    RileyD_Score score;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public int Lives
    {
        get { return lives; }
    }
    // Use this for initialization
    void Start()
    {
        switch (RileyD_Options.gamePlayMode)
        {
            case 0:
                lives = 10;
                break;
            case 1:
                lives = 5;
                break;
            case 2:
                lives = 3;
                break;
        } 

        levelManager = GameObject.FindObjectOfType<RileyD_LevelManager>();
        score = GameObject.FindObjectOfType<RileyD_Score>();
    }

    public void livesReset()
    {
        switch (RileyD_Options.gamePlayMode)
        {
            case 0:
                lives = 10;
                break;
            case 1:
                lives = 5;
                break;
            case 2:
                lives = 3;
                break;
        } 
        
        if (RileyD_Options.gamePlayMode == 0)
            lives = 10;
        else if (RileyD_Options.gamePlayMode == 1)
            lives = 5;
        else if (RileyD_Options.gamePlayMode == 2)
            lives = 3;
    }

    public void UpdateLives()
    {
        lives--;
        if (lives <= 0)
        {
            levelManager.LoadLevel("Lose");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
