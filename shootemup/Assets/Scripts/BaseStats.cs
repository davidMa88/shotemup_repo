using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseStats {

    public float health;
    public float shield;
    public float stamina;
    
    public float maxSpeed;
    public float aceleration;
    [Range(0f, 1f)]
    public float brake;
    public float weight;

    public float shootDamage;

}
