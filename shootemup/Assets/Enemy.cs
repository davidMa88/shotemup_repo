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
            //World.Bullets.Add((Bullet)Instantiate(new Bullet(bullet), transform.position, Quaternion.identity));

            Bullet newBullet = gameObject.AddComponent<Bullet>();
            newBullet.sprite = bullet.sprite;
		}
        
	}

}

[System.Serializable]
public class SBullet
{
    public string type;
    public Sprite sprite;
}