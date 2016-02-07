using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float health;
	
	public Bullet bullet;
	

	void Start(){
	}
    
	void Update(){

		if (Input.GetKeyDown (KeyCode.P)) {
            World.Bullets.Add((Bullet)Instantiate(bullet, transform.position, Quaternion.identity));
		}
        
	}

}
