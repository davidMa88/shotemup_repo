using UnityEngine;
using System.Collections;

namespace shootemup
{
    [RequireComponent(typeof(LineRenderer))]
    public class Player : BaseActor
    {

        protected override void Start()
        {
            base.Start();

            movementController.axisDebug = GetComponent<LineRenderer>();
        }

        override protected void Update()
        {

            base.Update();

            var action = Action.MoveAction.NONE;

            if (Input.GetKey(KeyCode.Space))
                action = Action.MoveAction.BRAKE;
            else if (Input.GetKey(KeyCode.UpArrow))
                action = Action.MoveAction.UP;
            else if (Input.GetKey(KeyCode.DownArrow))
                action = Action.MoveAction.DOWN;
            else if (Input.GetKey(KeyCode.LeftArrow))
                action = Action.MoveAction.LEFT;
            else if (Input.GetKey(KeyCode.DownArrow))
                action = Action.MoveAction.DOWN;

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
}