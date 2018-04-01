using System.Collections;
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

	//growUpState
		//small
		//smallToBig
		//big
		//bigToSmall

		private Rigidbody2D m_physic;
		private int m_direction;//left -1, right 1, else 0
		//private Gravity m_gravity;
		private Transform m_transform;
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
		setAnimations();
		setSound();
		setMove();

		//handle Move animation
		/*if(physic.velocity.distance == 0 ){
			moveState = MoveState.iddle;
		}else if(physic.velocity.value > runSpeed){
			moveState = MoveState.run;
		}else{
			moveState = MoveState.walk;
		}*/

	}
	//external functions to set the state
	public void seeFire(Vector2 position){
		//fear + force in oposite direction
		humorState = HumorState.fear;
		//Vector2 tmp = transform.position -position;
	}
	public void unseeFire(){
		//happy + state + stop
	}
	public void seeLight(Vector2 position){
		//happy + force in same direction
	}
	private void setAnimations(){

	}
	private void setMove(){

	}
	private void setSound(){

	}
}
