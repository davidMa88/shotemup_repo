using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float health;
	public float velocidad;

	public GameObject bullet;
	GameObject newBullet;

	void Start(){
	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.P)) {
			newBullet = (GameObject)Instantiate (bullet, transform.position, Quaternion.identity);
			Debug.Log (newBullet.transform.position);
		}

		if (Input.GetKey (KeyCode.X)) {
			Destroy(newBullet);
		}

		if (newBullet != null) {
			newBullet.transform.position += Vector3.down * Time.deltaTime * velocidad;
		}
	}

}
