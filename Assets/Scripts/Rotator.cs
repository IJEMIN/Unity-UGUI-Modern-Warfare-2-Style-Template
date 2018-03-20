using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	public Vector3 speed = new Vector3(0f,30f,0f);
	void Update () {
		transform.Rotate(speed * Time.deltaTime);		
	}
}
