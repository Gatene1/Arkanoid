using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RileyD_LevelManager : MonoBehaviour
{

    Scene currScene;
    RileyD_Lives lives;
    RileyD_Score score;

    // Use this for initialization
    void Start(){
        currScene = SceneManager.GetActiveScene();
        lives = GameObject.FindObjectOfType<RileyD_Lives>();
        score = GameObject.FindObjectOfType<RileyD_Score>();
    }
    // Good for button use
    public void LoadLevel(string name)
    {
        switch (name)
        {
            case "Start":
            case "Lose":
                lives.livesReset();
                score.scoreReset();
                RileyD_Block.blocksInScene = 0;
                break;

            case "Level_01E":
                Destroy(lives);
                Destroy(score);
                RileyD_Options.gamePlayMode = 0;
                name = "Level_01";
                break;

            case "Level_01N":
                Destroy(lives);
                Destroy(score);
                RileyD_Options.gamePlayMode = 1;
                name = "Level_01";
                break;

            case "Level_01H":
                Destroy(lives);
                Destroy(score);
                RileyD_Options.gamePlayMode = 2;
                name = "Level_01";
                break;
        }

        SceneManager.LoadScene(name);
    }
    // Loading the next scene in order
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(currScene.buildIndex + 1);
    }

    // LastBlockDestroyed loads next level
    public void lastBlockDestroyed()
    { 
        if (RileyD_Block.blocksInScene <= 0)
        {
            LoadNextLevel();
        }
    }

    // Quit Game
    public void GameQuit()
    {
        Application.Quit();
    }

}
