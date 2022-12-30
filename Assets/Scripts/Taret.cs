using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taret : MonoBehaviour
{
    public GameObject projectileObject;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnProjectileObject", 0.2f, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    GameObject spawnProjectileObject()
    {
        GameObject projectile = Instantiate(projectileObject);
        return projectile;
    }
}
