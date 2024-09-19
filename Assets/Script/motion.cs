using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{
    public float speed = 10F;
    Rigidbody rd;
    float xinput;
    float yinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        xinput = Input.GetAxis("Horizontal");
        yinput = Input.GetAxis("Vertical");
        rd.AddForce(xinput*speed, 0 ,yinput*speed);
    }
}
