using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlayerMovement : MonoBehaviour {

	public float maxSpeed;
	public float aceleration;
	[Range(0f, 1f)]
	public float brake;

	public Text speedDebug;

	Rigidbody2D rigidBody;
	LineRenderer axisDebug;
	Vector3 axis;

	float normalizedBrake;
	float minBrakeValue = 0.5f;


	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		axisDebug = GetComponent<LineRenderer> ();
	}

	void Update () {
		
		float dx = Input.GetAxis("Horizontal");
		float dy = Input.GetAxis("Vertical");

		rigidBody.velocity += new Vector2 (dx, dy) * Time.fixedDeltaTime * aceleration;

		if (Input.GetKey (KeyCode.Space)) {
			rigidBody.velocity *= normalizedBrake;
			axis *= normalizedBrake;
		}
		else if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.RightArrow)) {
			axis = new Vector3 (Input.GetAxis ("Horizontal") * 2, Input.GetAxis ("Vertical") * 2, 0);
		}

        if (speedDebug != null)
		    speedDebug.text = rigidBody.velocity.magnitude.ToString ();

		axisDebug.SetPosition (0, transform.position);
		axisDebug.SetPosition (1, transform.position + axis);
	}

	void FixedUpdate() {
		
		if(rigidBody.velocity.magnitude > maxSpeed)
		{
			rigidBody.velocity = rigidBody.velocity.normalized * maxSpeed;
		}

	}

	void OnValidate(){

		normalizedBrake = brake;
		normalizedBrake = minBrakeValue + normalizedBrake - (minBrakeValue * normalizedBrake);  // <-- Obligo que sea entre 0.5f y 1f 
		normalizedBrake = minBrakeValue - normalizedBrake + 1.0f;						 		// <-- Invierto el valoe (cuando 0.5f es 1f, cuando 1f es 0.5f)

	}

}
