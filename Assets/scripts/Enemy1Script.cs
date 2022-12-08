using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Script : MonoBehaviour
{
    public int verticalDirection = 1;
    public int horizontalDirection = -1;
    public float verticalVelocity = 3;
    public float horizontalVelocity = 2;
    private float minHorizontalRange;
    private float maxHorizontalRange;
    public float randomHorizontalPositionMax;
    public float randomHorizontalPositionMin;
    private float minVerticalRange;
    private float maxVerticalRange;
    public float randomVerticalPositionMax;
    public float randomVerticalPositionMin;

    void Start()
    {
        minHorizontalRange = 0f;
        maxHorizontalRange = 8f;
        minVerticalRange = -4.5f;
        maxVerticalRange = 4.5f;
        RandomPositionMin();
        RandomPositionMax();
        RandomVerticalPositionMin();
        RandomVerticalPositionMax();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > maxHorizontalRange) {
        transform.Translate(-1 * horizontalVelocity * Time.deltaTime, 0,0);
        } else {
            transform.Translate(horizontalDirection * horizontalVelocity * Time.deltaTime, verticalDirection * verticalVelocity * Time.deltaTime,0);
            if(transform.position.x >= maxHorizontalRange)
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
            if (transform.position.y >= maxVerticalRange)
            {
                verticalDirection = -1;
            }
            else
            {
                if (verticalDirection < 0 && transform.position.y <= randomVerticalPositionMin)
                {
                    verticalDirection = 1;
                    Debug.Log(horizontalDirection);
                    RandomVerticalPositionMin();
                }
                if (verticalDirection > 0 && transform.position.y >= randomVerticalPositionMax)
                {
                    horizontalDirection = -1;
                    RandomVerticalPositionMax();
                }
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
    private void RandomVerticalPositionMin()
    {
        randomVerticalPositionMin = Random.Range(minVerticalRange, transform.position.y);
        Debug.Log("randomMin: " + randomHorizontalPositionMin);
    }
    private void RandomVerticalPositionMax()
    {
        randomVerticalPositionMax = Random.Range(transform.position.y, maxVerticalRange);
        Debug.Log("randomMin: " + randomHorizontalPositionMin);

    }
}
