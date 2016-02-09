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
            var go = new GameObject("Bullet", typeof(Bullet));
            go.GetComponent<Bullet>().SetInitialPosition(transform.position);
            go.GetComponent<Bullet>().SetSprite(bullet.sprite);
		}
        
	}

}

[System.Serializable]
public class SBullet
{
    public Sprite sprite;
}