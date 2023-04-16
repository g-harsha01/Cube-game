using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovemnt : MonoBehaviour
{   
    public float ForwardForce= 1000f;
    public float SideForce= 1000f;
    
    public Rigidbody rb;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, ForwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce((-1*SideForce) * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<Game_Manager>().Endgame();
        }

    }
}
