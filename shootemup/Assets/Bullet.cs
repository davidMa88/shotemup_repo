using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class Bullet : MonoBehaviour {

    public Sprite sprite;

	void Start () {
        GetComponent<SpriteRenderer>().sprite = sprite;
	}
	
	void Update () {
	
	}
}
