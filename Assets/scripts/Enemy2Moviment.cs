using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Moviment : MonoBehaviour
{
    public float randomHorizontalPosition;
    public float randomVerticalPosition;
    public float horizontalVelocity = -1;
    public float verticalVelocity = 2;
    public int verticalDirection = 3;
    // Start is called before the first frame update
    void Start()
    {
        RandomPositionHorizontal();
        RandomPositionVertical();
        if (randomVerticalPosition > transform.position.y)
        {
            verticalDirection = 1;
        }
        if (randomVerticalPosition < transform.position.y)
        {
            verticalDirection = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= randomHorizontalPosition)
        {
            horizontalVelocity = 0;
        }
        if (randomVerticalPosition > transform.position.y && verticalDirection == -1)
        {
            verticalVelocity = 0;
        }
        if (randomVerticalPosition < transform.position.y && verticalDirection == 1)
        {
            verticalVelocity = 0;
        }
        if (randomVerticalPosition == transform.position.y)
        {
            verticalVelocity = 0;
        }
        transform.Translate(horizontalVelocity * Time.deltaTime, verticalVelocity * verticalDirection * Time.deltaTime, 0);
    }
    private void RandomPositionHorizontal()
    {
        randomHorizontalPosition = Random.Range(0f, 8f) + 1;
    }
    private void RandomPositionVertical()
    {
        randomVerticalPosition = Random.Range(4f, -4f);
    }
}
