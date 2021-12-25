using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct SceneDescriptor
{
    public string name;
    public string description;
}

public class ScenesPanelController : MonoBehaviour {

    public SceneDescriptor[] scenes;
    public GameObject sceneLaunchButtonPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
