using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour {

    //State of the switch
    public bool isOn;

    //Light object that will be affected by the switch
    public GameObject externalObject;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    }

    private void OnMouseDown()
    {
        isOn = !isOn;
        ExternalAction script = externalObject.GetComponent<ExternalAction>();
        script.ExecuteAction(isOn);
    }   
}
