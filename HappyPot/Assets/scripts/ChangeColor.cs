using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : ExternalAction {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void ExecuteAction(bool isOn)
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        //If switch is on
        if (isOn)
        {
            renderer.color = new Color(255f, 0f, 0f, 1f); // red
        }
        else   //if switch is off
        {
            renderer.color = new Color(0f, 0f, 255f, 1f); // blue
        }
    }

}
