using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEndController : MonoBehaviour {

    public GameObject animation1;

    public GameObject animation2;

    // Use this for initialization
    void Start() {
        animation2.SetActive(false);
        StartCoroutine("WaitAnimation1");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator WaitAnimation1()
    {
        yield return new WaitForSeconds(4);
        animation1.SetActive(false);
        animation2.SetActive(true);
    }
}
