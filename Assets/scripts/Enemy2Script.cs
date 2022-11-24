using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour
{
    public GameObject projectileOutput1;
    public GameObject projectileOutput2;
    public GameObject projectileOutput3;
    public GameObject projectileOutput4;

    public GameObject projectile;

    private float timer;
    public float delay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, 0.3f);
        timer += Time.deltaTime;
        if(timer > 1)
        {
            Instantiate(projectile, projectileOutput1.transform.position, projectileOutput1.transform.rotation);
            Instantiate(projectile, projectileOutput2.transform.position, projectileOutput2.transform.rotation);
            Instantiate(projectile, projectileOutput3.transform.position, projectileOutput3.transform.rotation);
            Instantiate(projectile, projectileOutput4.transform.position, projectileOutput4.transform.rotation);

            timer = 0;
        }
    }
}
