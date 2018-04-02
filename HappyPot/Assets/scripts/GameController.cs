using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : ExternalAction{

    public int nbLights;

	// Use this for initialization
	void Start () {

	}

    // Update is called once per frame
    void Update()
    {
        if (nbLights == 0)
        {
            //SceneManager.LoadScene("Game_Over", LoadSceneMode.Single);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level_1", LoadSceneMode.Single);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }

    public override void ExecuteAction(bool isOn)
    {
        nbLights--;
    }

}
