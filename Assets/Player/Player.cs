using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
	public new Camera camera;

	void Start ()
	{
		
	}

	void Update ()
	{
		Vector3 pos = camera.transform.position;
		pos.z = transform.position.z;
		camera.transform.position = pos;
	}
}