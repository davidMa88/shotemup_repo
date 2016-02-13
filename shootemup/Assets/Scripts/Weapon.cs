using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class Weapon : MonoBehaviour {

    public SBullet bullet;

    // Use this for initialization
    void Start () {
        transform.localPosition = new Vector3(0, 0.5f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void Shoot(Vector3 direction)
    {
        var newBullet = new GameObject("Bullet", typeof(Bullet)).GetComponent<Bullet>();
        newBullet.SetInitialPosition(transform.position);
        newBullet.SetDirection(direction);
        newBullet.SetSprite(bullet.sprite);
        newBullet.SetLifeTime(bullet.lifeTime);
        newBullet.SetSpeed(bullet.speed);
    }

    public void SetSprite(Sprite sprite)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }
}

