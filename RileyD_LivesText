using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RileyD_LivesText : MonoBehaviour
{

    Component[] livesTextTemp;
    Text livesText;
    RileyD_Lives getLives;

    // Use this for initialization
    void Start()
    {
        livesTextTemp = gameObject.GetComponentsInChildren<Text>();
        foreach (Text text in livesTextTemp)
        {
            if (text.name == "LivesLeft")
            {
                livesText = text;
            }
        }
        getLives = GameObject.FindObjectOfType<RileyD_Lives>();
    }

    // Update is called once per frame
    void Update()
    {
        int livesAvail = getLives.Lives;
        livesText.text = "Lives: " + livesAvail;
    }
}
