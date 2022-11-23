using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    private float velocity = 12.0f;
    public GameObject explosionAnim;
    public GameObject explosionLocation;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity * Time.deltaTime,0,0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player") && !other.CompareTag("Projectile"))
        {
            Instantiate(explosionAnim, explosionLocation.transform.position, explosionLocation.transform.rotation);
            Destroy(this.gameObject);
        }
    }

}
