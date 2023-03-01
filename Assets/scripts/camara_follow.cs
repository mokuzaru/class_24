using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *This script is make the camara follow the player
 *
 *
 *Made by Mokuzaru
 *2019
*/

public class camara_follow : MonoBehaviour {

	public Vector3 offset;
	private Transform target;
	[Range (0,1)]public float lerpValue;
	public float sensibilidad;

	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag("Player").transform;	
	}

	// Update is called once per frame
	void LateUpdate () {
		transform.position = Vector3.Lerp (transform.position, target.position + offset, lerpValue);

		offset = Quaternion.AngleAxis (Input.GetAxis ("Mouse X") * sensibilidad, Vector3.up)* offset;

		transform.LookAt (target);
	}
}
