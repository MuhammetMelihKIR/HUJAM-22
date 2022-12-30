using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_shoot : MonoBehaviour
{
    public GameObject enemyProjectile;
    void Start()
    {
        InvokeRepeating("enemySpawnProjectile", 0.2f, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    GameObject enemySpawnProjectile()
    {
        GameObject enemyProObject = Instantiate(enemyProjectile);
        return enemyProObject;
    }
}
