using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollision : MonoBehaviour {
	//private GameObject gameObject;
	public float attractionCoef = 1.0f;
	//private Gravity m_gravity;
	private Transform transform;
// Use this for initialization
	void Start () {
		transform = gameObject.GetComponent<Transform>();
 }


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
		PotState tmp = other.GetComponentInParent<PotState>();
		tmp.seeLight(transform.position,attractionCoef);
	}
	/*void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log("exit");
		//other.PotState.seeLight();
	}*/
}
