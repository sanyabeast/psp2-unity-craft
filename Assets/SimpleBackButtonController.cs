using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBackButtonController : MonoBehaviour {

    public GameObject pauseMenuPrefab;
    GameObject currentPauseMenuInstance;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Cancel"))
        {
            if (currentPauseMenuInstance == null){
                currentPauseMenuInstance = Instantiate(pauseMenuPrefab);
            }
            else
            {
                Destroy(currentPauseMenuInstance);
            }
            
        }
	}
}
