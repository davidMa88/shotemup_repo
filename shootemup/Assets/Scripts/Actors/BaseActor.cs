using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class BaseActor : MonoBehaviour {

    public BaseStats stats;
    public SWeapon weapon;

    protected MovementController movementController;
    protected Rigidbody2D rigidBody;

    
    void Start () {
        movementController = new MovementController();

        rigidBody = GetComponent<Rigidbody2D>();

        var go = new GameObject("Weapon", typeof(Weapon)).GetComponent<Weapon>();
        go.transform.parent = transform;
        go.SetSprite(weapon.sprite);
        go.bullet = weapon.bullet;
    }
	
	
	void Update () {
	
	}
}
