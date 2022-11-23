using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocity = 10f;
    public Animator anim;
    void Update()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");
        if(verticalAxis > 0)
        {
            anim.SetBool("Up", true);
            anim.SetBool("Down", false);
        }
        else if(verticalAxis < 0)
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", true);
        } 
        else
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
        }
        transform.Translate( horizontalAxis * velocity * Time.deltaTime, verticalAxis * velocity * Time.deltaTime,0);
    }

}
