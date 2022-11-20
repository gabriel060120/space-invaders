using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocity = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.SetPositionAndRotation( Vector3f(Input.GetAxis("Horizontal") * velocity * Time.deltaTime, Input.GetAxis("Vertical") * velocity * Time.deltaTime, 0), transform.rotation);
        transform.Translate(Input.GetAxis("Horizontal") * velocity * Time.deltaTime, Input.GetAxis("Vertical") * velocity * Time.deltaTime,0);
    }
}
