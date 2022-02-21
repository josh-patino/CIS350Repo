/*
* Josh Patino
* Prototype 3 Assignment 4
* controls the player movement, c
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip jumpSound; 
    public AudioClip crashSound; 
    private AudioSource playerAudio; 
    public ParticleSystem explosionParticle; 
    public ParticleSystem dirtParticle; 
    public Animator playerAnimator; 
    private Rigidbody rb; 
    public float jumpForce;
    public bool isOnGround = true; 
    public ForceMode forceMode; 
    public bool gameOver = false; 
    public float gravityModifier; 

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerAnimator = GetComponent<Animator>(); 
        playerAnimator.SetFloat("Speed_f", 1.0f);
        rb = GetComponent<Rigidbody>(); 
        forceMode = ForceMode.Impulse;

        if(Physics.gravity.y > -10)
        {
        Physics.gravity *= gravityModifier; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce,forceMode); 
            isOnGround = false; 

            //play jump animation
            playerAnimator.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Ground") && !gameOver)
       {
           isOnGround = true; 
           dirtParticle.Play(); 
       } 
       else if (collision.gameObject.CompareTag("Obstacle") && !gameOver)
       {
           playerAnimator.SetBool("Death_b", true);
           playerAnimator.SetInteger("DeathType_int", 1);  
           Debug.Log("Game is over!");
           gameOver = true; 
           playerAudio.PlayOneShot(crashSound, 1.0f); 
           explosionParticle.Play();

       }
    }

}
