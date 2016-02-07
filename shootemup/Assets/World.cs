using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class World : MonoBehaviour {

    public static List<Bullet> Bullets { get; set; }
    
    void Start()
    {
        Bullets = new List<Bullet>();
    }

    void Update()
    {
        foreach (var bullet in Bullets)
        {
            bullet.transform.position += Vector3.down * Time.deltaTime * 10.0f;
        }
    }
}
