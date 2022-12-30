using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCont : MonoBehaviour
{
    public float hitPoints;
    public float maxHitPoints;
   // public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        hitPoints=maxHitPoints;
       // healthBar.setHealth(hitPoints, maxHitPoints);

    }

    public void takeHit(float damage)
    {

        hitPoints-=damage;
      //  healthBar.setHealth(hitPoints, maxHitPoints);
        if (hitPoints <= 0)
        {
            platformScript.destroy3 = true;
            Destroy(gameObject);
            
        }
    }
    
}
