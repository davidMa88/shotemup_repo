using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

    public BaseStats stats;

    private PlayerMovement _playerMovement;
    private Rigidbody2D rigidBody;

    // Use this for initialization
    void Start () {

        _playerMovement = new PlayerMovement();

        rigidBody = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        _playerMovement.Update(ref rigidBody, stats.aceleration);
        
	}
}
