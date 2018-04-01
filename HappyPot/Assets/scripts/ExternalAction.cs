using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void ExecuteAction(bool isOn)
    {
        //If switch is on
        if (isOn)
        {
            Debug.Log("Light on");
        }
        else   //if switch is off
        {
            Debug.Log("Light off");
        }
    }
}
