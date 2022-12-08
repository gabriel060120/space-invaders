using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float velocity = 8.0f;
    public GameObject explosionAnim;
    public GameObject explosionLocation;
    public GameObject hitToProjectile;
    public bool isPlayer = true;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity * Time.deltaTime,0,0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("limit"))
        {
            Destroy(this.gameObject);
        }
        if(isPlayer)
        {
            if (!other.CompareTag("Player") && !other.CompareTag("Projectile") && !other.CompareTag("EnemyProjectile") && !other.CompareTag("limit"))
            {
                Instantiate(explosionAnim, explosionLocation.transform.position, explosionLocation.transform.rotation);
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }
        else
        {
            if (!other.CompareTag("Enemy") && !other.CompareTag("EnemyProjectile") && !other.CompareTag("limit"))
            {
                Instantiate(hitToProjectile, transform.position, transform.rotation);
                if(other.CompareTag("Player"))
                    Application.Quit();
                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
        }
        
    }

}
