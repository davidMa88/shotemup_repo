using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float health;
    public SWeapon weapon;
    
	void Start(){
        var go = new GameObject("Weapon", typeof(Weapon)).GetComponent<Weapon>();
        go.transform.parent = transform;
        go.SetSprite(weapon.sprite);
        go.bullet = weapon.bullet;
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            var weapon = GetComponentInChildren<Weapon>();
            var shootDirection = weapon.transform.position - transform.position;
            shootDirection = shootDirection / shootDirection.magnitude; //Vector unitario

            Debug.Log(shootDirection);

            weapon.Shoot(shootDirection);
        }
    }

}

[System.Serializable]
public class SWeapon
{
    public Sprite sprite;
    public SBullet bullet;
}

[System.Serializable]
public class SBullet
{
    public Sprite sprite;
    public float lifeTime;
    public float speed;
}

