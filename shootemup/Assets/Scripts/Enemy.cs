using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float health;

    [SerializeField]
    public SBullet bullet;
    

	void Start(){
	}
    
	void Update(){

		if (Input.GetKeyDown (KeyCode.P)) {
            var newBullet = new GameObject("Bullet", typeof(Bullet)).GetComponent<Bullet>();
            newBullet.SetInitialPosition(transform.position);
            newBullet.SetSprite(bullet.sprite);
            newBullet.SetLifeTime(bullet.lifeTime);
		}
        
	}

}

[System.Serializable]
public class SBullet
{
    public Sprite sprite;
    public float lifeTime;
}