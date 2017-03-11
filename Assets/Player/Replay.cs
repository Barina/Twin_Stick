using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replay : MonoBehaviour
{
	private GameManager gameManager;
	private const int bufferSize = 100;
	private ReplayKeyFrame[] frames = new ReplayKeyFrame[bufferSize];
	private Rigidbody body;

	void Start ()
	{
		gameManager = GameObject.FindObjectOfType<GameManager> ();
		body = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		if (gameManager.Recording)
			Record ();
		else
			Playback ();
	}

	void Playback	()
	{
		body.isKinematic = true;
		int frame = Time.frameCount % bufferSize;
		Debug.Log ("Reading frame " + frame);
		transform.position = frames [frame].Position;
		transform.rotation = frames [frame].Rotation;
	}

	void Record ()
	{
		body.isKinematic = false;
		int frame = Time.frameCount % bufferSize;
		Debug.Log ("Writing to frame " + frame);
		frames [frame] = new ReplayKeyFrame (Time.time, transform.position, transform.rotation);
	}
}

public class ReplayKeyFrame
{
	public float Time{ get; private set; }

	public Vector3 Position{ get; private set; }

	public Quaternion Rotation{ get; private set; }

	public ReplayKeyFrame (float time, Vector3 position, Quaternion rotation)
	{
		this.Time = time;
		this.Position = position;
		this.Rotation = rotation;
	}
}