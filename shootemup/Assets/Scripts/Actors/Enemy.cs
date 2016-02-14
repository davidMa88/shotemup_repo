using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : BaseActor {
    
    void Start(){

        
	}

    void Update()
    {
        //var direction = new Vector2(1, 0);
        //var action = Action.NONE;
        //movementController.CalculateVelocity(ref rigidBody, stats, direction, action);

        if (Input.GetKeyDown(KeyCode.P))
        {
            var weapon = GetComponentInChildren<Weapon>();
            var shootDirection = weapon.transform.position - transform.position;
            shootDirection = shootDirection / shootDirection.magnitude; //Vector unitario
            weapon.Shoot(shootDirection);
        }
    }

}



