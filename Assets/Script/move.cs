using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody remoteRB;
    Vector3 myInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");//a/d or left/right
        float vertical = Input.GetAxis("Vertical");//w/s or up/down

        myInput = vertical * transform.forward;
        myInput += horizontal * transform.right;
    }
    private void FixedUpdate()
    {
        remoteRB.velocity = myInput * 10f;
    }

}
