using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : ExternalAction{

    private int count;

    //External object that will be affected by the switch
    public GameObject externalObject;

    // Use this for initialization
    void Start () {
        count = 0;
	}

	// Update is called once per frame
	void Update () {

	}

    public override void ExecuteAction(bool isOn)
    {
        gameObject.SetActive(false);
        if (isOn)
        {
            gameObject.SetActive(false);
						gameObject.GetComponent<LightCollision>().off();
            count++;
        }
        if (count == 1) {
            ExternalAction script = externalObject.GetComponent<ExternalAction>();
            script.ExecuteAction(isOn);
        }
    }
}
