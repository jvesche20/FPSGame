using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    BulletScript bulletScript;
    // Start is called before the first frame update
    void Start()
    {
        bulletScript = gameObject.AddComponent<BulletScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(bulletScript.hitBool);
        if (bulletScript.hitBool == true)
        {

            
        }
        
    }
}
