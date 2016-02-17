using UnityEngine;
using System.Collections;

namespace shootemup
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Enemy : BaseActor
    {
        Weapon _weapon; //<--cambiar
        protected override void Start()
        {
            base.Start();

            transform.FollowPath("TestPath", 10f, Mr1.FollowType.PingPong).SmoothLookForward(true, 10f);

            _weapon = GetComponentInChildren<Weapon>();
        }

        protected override void Update()
        {
            base.Update();

            //var shootDirection = _weapon.transform.position - transform.position;
            //shootDirection = shootDirection / shootDirection.magnitude; //Vector unitario
            //
            //var action = Action.MoveAction.NONE;
            //if (Input.GetKey(KeyCode.Space))
            //    action = Action.MoveAction.BRAKE;
            //
            //movementController.CalculateVelocity(ref rigidBody, stats, shootDirection, action);

            //if (Input.GetKeyDown(KeyCode.P))
            //{
            //    var weapon = GetComponentInChildren<Weapon>();
            //    var shootDirection = weapon.transform.position - transform.position;
            //    shootDirection = shootDirection / shootDirection.magnitude; //Vector unitario
            //    weapon.Shoot(shootDirection);
            //}
        }

    }
}



