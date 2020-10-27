using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RileyD_LevelText : MonoBehaviour {

    Text levelText;
    Component[] levelTextTemp;
    string levelName;
    int levelNumber;
    [SerializeField]
    int levelTextNumber;

	// Use this for initialization
	void Start () {
        levelTextTemp = gameObject.GetComponentsInChildren<Text>();
        foreach (Text text in levelTextTemp)
        {
            if (text.name == "Level")
                levelText = text;
        }
        
        levelText.text = "Level " + levelTextNumber;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
