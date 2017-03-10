using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
	void Start ()
	{
		
	}

	void Update ()
	{
		if (CrossPlatformInputManager.GetButtonDown ("right")) {
			// will move the ball right
		}
		if (CrossPlatformInputManager.GetButtonDown ("left")) {
			// will move the ball left
		}
	}
}