using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitControls : MonoBehaviour {

	// Use this for initialization
    public Vector3 target = new Vector3(0f, 0f, 0f  );
    public float horizMove = 1f;
    public float vertMove = 1f;
    public float moveSpeed = 1f;
	void Start () {
		
	}
	

    public void LookHorizontal(bool left, float strength = 1f)
    {
        float dir = left ? -1f : 1f;
        transform.RotateAround(target, Vector3.up, horizMove * dir * strength);
    }

    public void LookVertical(bool up, float strength = 1f)
    {
        float dir = up ? -1f : 1f;
        transform.RotateAround(target, transform.TransformDirection(Vector3.right), vertMove * dir * strength);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
