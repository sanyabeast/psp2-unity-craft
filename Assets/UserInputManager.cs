using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputManager : MonoBehaviour {

    public OrbitControls orbitCamera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            orbitCamera.LookHorizontal(true);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            orbitCamera.LookHorizontal(false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            orbitCamera.LookHorizontal(true);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            orbitCamera.LookHorizontal(false);
        }

        orbitCamera.LookHorizontal(true, Input.GetAxis("HorizontalTurn"));
        orbitCamera.LookVertical(true, Input.GetAxis("VerticalTurn"));

        //Debug.Log(Input.GetAxis("Horizontal"));
        //Debug.Log(Input.GetAxis("VerticalTurn"));
	}
}
