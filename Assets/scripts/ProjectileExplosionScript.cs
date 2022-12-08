using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileExplosionScript : MonoBehaviour
{
    private float timer;
    public float timeAnimation = 0.7f;

    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeAnimation)
        {
            Destroy(gameObject);
        }
    }
}
