using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    
    public static bool hit = false;
    private int hp = 100;
    public int bulletDamage = 20;
    Random rnd = new Random();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            if(hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                hp -= bulletDamage;

                hit = false;
            }
        }
    }
    public void EnemyHit()
    {
        hit = true;

    }
}
