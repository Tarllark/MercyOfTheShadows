using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingScript : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform bulletSpawn;
    public float projectileForce = 500f;
    public float fireRate = .25f;

    private float nextFireTime;

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime)
        {
            fire();
            //test();
        }
    }

    void test()
    {
        Rigidbody projectile = Instantiate(bullet, bulletSpawn.transform.position, Quaternion.identity);
    }

    void fire()
    {
        Rigidbody iProjectile = Instantiate(bullet, bulletSpawn.transform.position, Quaternion.identity);
        iProjectile.AddForce(bulletSpawn.transform.forward * projectileForce);
        nextFireTime = Time.time + fireRate;
    }


}
