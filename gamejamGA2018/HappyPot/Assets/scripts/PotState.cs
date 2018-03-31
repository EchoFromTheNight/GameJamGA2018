using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotState : MonoBehaviour {
	//moveState
	enum MoveState {iddle, walk, run};
	//s1 iddle
	//s2 walk
	//s3 run

	//fearState
	//fear
	//Happy
	private bool isFeared;

	//growUpState
		//small
		//smallToBig
		//big
		//bigToSmall
		
		private Rigidbody2D m_physic;
		private int m_direction;//left -1, right 1, else 0
		private Gravity m_gravity;
		private Transform m_transform;
	// Use this for initialization
	void Start () {
		isFeared = false;
	}

	// Update is called once per frame
	void Update () {

	}
}
