﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotState : MonoBehaviour {
	//moveState
	enum MoveState {iddle, walk, run};
	//fearState
	enum HumorState {happy, fear};
	//growUpState
	enum GrowUpState{small, smallToBig, big, bigToSmall};
	//states
	private MoveState moveState;
	private HumorState humorState;
	private GrowUpState growUpState;
	private int direction;//left -1, right 1, else 0
	public float maxSpeed = 10.0f;
	public float runSpeed = 5.0f;
	public float jump = 1.0f;
	//growUpState
		//small
		//smallToBig
		//big
		//bigToSmall

		private Rigidbody2D m_physic;
		private int m_direction;//left -1, right 1, else 0
		//private Gravity m_gravity;
		private Transform transform;
		private Rigidbody2D physic;
	// Use this for initialization
	void Start () {
		moveState = MoveState.iddle;
		humorState = HumorState.happy;
		growUpState = GrowUpState.small;
		direction = 0;
		transform = gameObject.GetComponent<Transform> ();
		physic = gameObject.GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		setMove();
		setAnimations();
		setSound();
		Debug.Log("test");
		physic.AddForce(Vector2.up * jump);
	}
	//external functions to set the state
	public void seeFire(Vector2 position, float repulsionCoef ){//ok
		//fear + force in oposite direction
		humorState = HumorState.fear;
		float tmpX = transform.position.x - position.x;
		if(Mathf.Abs(physic.velocity.x) < maxSpeed)
		physic.AddForce(Vector2.right * repulsionCoef / tmpX);
	}
	public void unseeFire(){//ok
		humorState = HumorState.happy;
		//happy + state + stop
	}
	public void seeLight(Vector2 position, float attractionCoef ){//ok
		//happy + force in same direction
		float tmpX = transform.position.x - position.x;


		Debug.Log("seeLight : "/* + tmpX*/);
		if(physic.velocity.x<maxSpeed)
			physic.AddForce(Vector2.left * attractionCoef * Mathf.Sign(tmpX));
	}
	private void setAnimations(){
		Debug.Log("moveState : " + moveState);
	}

	private void setMove(){
		//handle Move animation
		if(physic.velocity.x == 0 ){
			moveState = MoveState.iddle;
		}else if(physic.velocity.x> runSpeed){
			moveState = MoveState.run;
		}else{
			moveState = MoveState.walk;
		}
	}
	private void setSound(){

	}


	void OnTriggerStay(Collider other)
	{
		Debug.Log("inside");
		//other.PotState.seeLight();
	}




}
