using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class Bullet : MonoBehaviour {
    
    private Sprite sprite;
    private float lifeTime = 0.5f;
    
	void Start ()
    {
        Destroy(gameObject, lifeTime);
    }
	
	void Update ()
    {
        transform.position += Vector3.down * Time.deltaTime * 10.0f;
    }

    public void SetInitialPosition(Vector3 pos)
    {
        transform.position = pos;
    }

    public void SetSprite(Sprite sprite)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
        this.sprite = sprite;
    }

    public void SetLifeTime(float lifeTime)
    {
        this.lifeTime = lifeTime;
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
        Debug.Log(col.gameObject);
    }
    
}
