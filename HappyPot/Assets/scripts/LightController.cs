using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : ExternalAction{

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    public override void ExecuteAction(bool isOn)
    {
        if (isOn)
        {
            gameObject.SetActive(false);
						gameObject.GetComponent<LightCollision>().off();
        }
    }
}
