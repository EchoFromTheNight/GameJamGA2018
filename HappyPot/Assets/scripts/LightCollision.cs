using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollision : MonoBehaviour {
	//GameObject gameObject;
	// Use this for initialization
	/*void Update () {
		Debug.Log("test 2");
	}*/
	/*void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("enter");
		//other.PotState.seeLight();
	}*/
	void OnTriggerStay2D(Collider2D other)
	{
		Debug.Log("inside");
		//other.parent.GetComponent<PotState>.seeLight();
	}
	/*void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log("exit");
		//other.PotState.seeLight();
	}*/
}
