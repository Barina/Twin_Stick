using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour
{
	public bool Recording{ get; private set; }

	void Start ()
	{
		Recording = true;
	}

	void Update ()
	{
		if (CrossPlatformInputManager.GetButtonDown ("Fire1")) {
			Recording = false;
		}
		if (CrossPlatformInputManager.GetButtonUp ("Fire1")) {
			Recording = true;
		}
	}
}