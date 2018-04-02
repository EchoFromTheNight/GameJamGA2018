using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("EndGame");
		SceneManager.LoadScene("EndGame",LoadSceneMode.Single);
	}

	// Update is called once per frame
	void Update () {

	}
}
