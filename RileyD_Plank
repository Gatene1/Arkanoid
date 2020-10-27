using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RileyD_Plank : MonoBehaviour {

	// Use this for initialization
	void Start () {

        if (RileyD_Options.gamePlayMode == 2)
            gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        else if (RileyD_Options.gamePlayMode == 1)
            gameObject.transform.localScale = new Vector3(1.9f, 1.25f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 plankPos = new Vector3(0.0f, this.transform.position.y, 0.0f);
        float mouseOffset = Input.mousePosition.x - Screen.width * 0.5f;
        float mouseInPlanks;
        switch (RileyD_Options.gamePlayMode)
        {
            case 0:
                mouseInPlanks = mouseOffset / Screen.width * 16;
                plankPos.x = Mathf.Clamp(mouseInPlanks, -6.8f, 6.8f);
                break;
            case 1:
                mouseInPlanks = mouseOffset / Screen.width * 16;
                plankPos.x = Mathf.Clamp(mouseInPlanks, -7.25f, 7.25f);
                break;
            case 2:
                mouseInPlanks = mouseOffset / Screen.width * 16;
                plankPos.x = Mathf.Clamp(mouseInPlanks, -7.7f, 7.7f);
                break;
        }

        this.transform.position = plankPos;
	}
}
