using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAmmo : MonoBehaviour
{
    private GunScript gunScript;

    private void Start()
    {
        gunScript = gameObject.AddComponent<GunScript>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ammo")
        {
            gunScript.updateAmmo(100);
            Destroy(other.gameObject);

        }
    }
}
