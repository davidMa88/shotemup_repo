using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class MovementController
{
    public LineRenderer axisDebug;
    public Vector3 axis;

    private float normalizedBrake;
    private float minBrakeValue = 0.5f;


    public MovementController()
    {
    }

    public void CalculateVelocity(ref Rigidbody2D rigidBody, BaseStats stats, Vector2 direction, Action action)
    {
        rigidBody.velocity += direction * Time.fixedDeltaTime * stats.aceleration;

        if (rigidBody.velocity.magnitude > stats.maxSpeed)
        {
            rigidBody.velocity = rigidBody.velocity.normalized * stats.maxSpeed;
        }

        if (action == Action.BRAKE)
        {
            normalizedBrake = stats.brake;
            normalizedBrake = minBrakeValue + normalizedBrake - (minBrakeValue * normalizedBrake);  // <-- Obligo que sea entre 0.5f y 1f 
            normalizedBrake = minBrakeValue - normalizedBrake + 1.0f;						 		// <-- Invierto el valoe (cuando 0.5f es 1f, cuando 1f es 0.5f)
            
            rigidBody.velocity *= normalizedBrake;
            axis *= normalizedBrake;
        }
        else if (action == Action.UP || action == Action.RIGHT || action == Action.DOWN || action == Action.LEFT)
        {
            axis = new Vector3(Input.GetAxis("Horizontal") * 2, Input.GetAxis("Vertical") * 2, 0);
        }

    }
}

//public Vector2 Update(ref Rigidbody2D rigidBody, float dx, float dy)
//{
//    rigidBody.velocity += new Vector2(dx, dy) * Time.fixedDeltaTime * aceleration;
//    Debug.Log(rigidBody.velocity);
//    return rigidBody.velocity;
//}
//void Start () {
//	rigidBody = GetComponent<Rigidbody2D> ();
//	axisDebug = GetComponent<LineRenderer> ();
//}

//void Update () {



//	rigidBody.velocity += new Vector2 (dx, dy) * Time.fixedDeltaTime * aceleration;

//	if (Input.GetKey (KeyCode.Space)) {
//		rigidBody.velocity *= normalizedBrake;
//		axis *= normalizedBrake;
//	}
//	else if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.RightArrow)) {
//		axis = new Vector3 (Input.GetAxis ("Horizontal") * 2, Input.GetAxis ("Vertical") * 2, 0);
//	}

//       if (speedDebug != null)
//	    speedDebug.text = rigidBody.velocity.magnitude.ToString ();

//	axisDebug.SetPosition (0, transform.position);
//	axisDebug.SetPosition (1, transform.position + axis);
//}