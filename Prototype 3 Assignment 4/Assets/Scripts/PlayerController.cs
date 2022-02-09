using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb; 
    public float jumpForce;
    public bool isOnGround = true; 
    public ForceMode forceMode; 
    public bool gameOver = false; 
    public float gravityModifier; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        forceMode = ForceMode.Impulse;
        Physics.gravity *= gravityModifier; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce,forceMode); 
            isOnGround = false; 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       
    }

}
