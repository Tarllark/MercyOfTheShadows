using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float despawn = 5f;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, despawn);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            destroyProjectile();
            Destroy(collision.gameObject);
        }
        else if (collision.transform.tag == "Border") destroyProjectile();
    }

    private void destroyProjectile()
    {
        Destroy(gameObject);
    }
}
