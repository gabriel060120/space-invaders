using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Script : MonoBehaviour
{
    public int verticalDirection = 1;
    public int horizontalDirection = -1;
    public float verticalVelocity = 2;
    public float horizontalVelocity = 2;
    private float minHorizontalRange;
    private float maxHorizontalRange;
    public float randomHorizontalPositionMax;
    public float randomHorizontalPositionMin;

    void Start()
    {
        minHorizontalRange = 0f;
        maxHorizontalRange = 8f;
        RandomPositionMin();
        RandomPositionMax();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(horizontalDirection * horizontalVelocity * Time.deltaTime, verticalDirection * verticalVelocity * Time.deltaTime,0);
        if(transform.position.x > 8)
        {
            horizontalDirection = -1;
        } else
        {
            if (horizontalDirection < 0 && transform.position.x <= randomHorizontalPositionMin)
            {
                horizontalDirection = 1;
                Debug.Log(horizontalDirection);
                RandomPositionMin();
            }
            if (horizontalDirection > 0 && transform.position.x >= randomHorizontalPositionMax)
            {
                horizontalDirection = -1;
                RandomPositionMax();
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("limit") || collision.gameObject.CompareTag("Enemy"))
        {
            verticalDirection *= -1;
        }
    }
    private void RandomPositionMin()
    {
        randomHorizontalPositionMin = Random.Range(minHorizontalRange, transform.position.x) + 1;
        Debug.Log("randomMin: " + randomHorizontalPositionMin);
    }
    private void RandomPositionMax()
    {
        randomHorizontalPositionMax = Random.Range(transform.position.x, maxHorizontalRange) - 1;
        Debug.Log("randomMin: " + randomHorizontalPositionMin);

    }
}
