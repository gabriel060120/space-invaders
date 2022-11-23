using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateProjectile : MonoBehaviour
{
    public GameObject projectile;
    private float timer = 0;
    public float delay = 0.5f;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= delay)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            timer = 0;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
