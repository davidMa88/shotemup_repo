using UnityEngine;
using System.Collections;



[System.Serializable]
public class SBullet
{
    public Sprite sprite;
    public float lifeTime;
    public float speed;
}


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class Bullet : MonoBehaviour {

    private Vector3 direction;
    private Sprite sprite;
    private float lifeTime = 0.5f;
    private float speed = 10.0f;
    
	void Start ()
    {
        Destroy(gameObject, lifeTime);
    }
	
	void Update ()
    {
        transform.position += this.direction * Time.deltaTime * this.speed;
    }

    public void SetInitialPosition(Vector3 pos)
    {
        transform.position = pos;
    }
    public void SetDirection(Vector3 direction)
    {
        this.direction = direction;
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
    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }


    public void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
        Debug.Log(col.gameObject);
    }
    
}
