using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemiesGeneratorScript : MonoBehaviour
{
    public GameObject enemyObject;
    public float generateDelay = 1f;
    private float timer;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > generateDelay )
        {
            Instantiate(enemyObject, transform.position, transform.rotation);
            timer = 0;
            counter++;
            if(counter % 50 == 0)
            {
                generateDelay = generateDelay / 2;
            }
        }
    }
}
