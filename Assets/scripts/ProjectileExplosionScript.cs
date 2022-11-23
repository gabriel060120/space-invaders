using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileExplosionScript : MonoBehaviour
{
    private float timer;

    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 0.7)
        {
            Destroy(gameObject);
        }
    }
}
