using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class Bullet : MonoBehaviour {

    private bool shooted = false;

    private float lifeTime = 0.5f;
    
	void Start ()
    {
        Destroy(gameObject, lifeTime);
    }
	
	void Update ()
    {
        if (shooted)
        {
            transform.position += Vector3.down * Time.deltaTime * 10.0f;
        }
    }

    public void SetInitialPosition(Vector3 pos)
    {
        transform.position = pos;
        shooted = true;
    }

    public void SetSprite(Sprite sprite)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }


    public void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
        Debug.Log(col.gameObject);
    }
    
}
