using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class Bullet : MonoBehaviour {

    public string type { get; private set; }
    public Sprite sprite;
    
	void Start () {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }
	
	void Update () { }
    
}
