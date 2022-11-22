using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateProjectile : MonoBehaviour
{
    public GameObject projectile;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1)
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
