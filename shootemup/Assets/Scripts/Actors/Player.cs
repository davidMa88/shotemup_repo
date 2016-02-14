using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]
public class Player : BaseActor {
    
    void Start () {
        
    }
	
	void Update () {

        var action = Action.NONE;

        if (Input.GetKey(KeyCode.Space))
            action = Action.BRAKE;
        else if (Input.GetKey(KeyCode.UpArrow))
            action = Action.UP;
        else if (Input.GetKey(KeyCode.DownArrow))
            action = Action.DOWN;
        else if (Input.GetKey(KeyCode.LeftArrow))
            action = Action.LEFT;
        else if (Input.GetKey(KeyCode.DownArrow))
            action = Action.DOWN;

        var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        
        movementController.CalculateVelocity(ref rigidBody, stats, direction, action);

        if (Input.GetKeyDown(KeyCode.P))
        {
            var weapon = GetComponentInChildren<Weapon>();
            var shootDirection = weapon.transform.position - transform.position;
            shootDirection = shootDirection / shootDirection.magnitude; //Vector unitario
            weapon.Shoot(shootDirection);
        }


        movementController.axisDebug.SetPosition(0, transform.position);
        movementController.axisDebug.SetPosition(1, transform.position + movementController.axis);
    }
}
