using System;
using UnityEngine;

// Controls player movement and rotation.
public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Set player's movement speed.
    public float rotationSpeed = 120.0f; // Set player's rotation speed.

    private Rigidbody rb; // Reference to player's Rigidbody.

    public float jumpForce = 5.0f;
    public ParticleSystem winEffect;
    public AudioSource winSound;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Access player's Rigidbody.
    }

    // Update is called once per frame
    private bool hasWon = false;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up*jumpForce,ForceMode.VelocityChange);
        }

        if (!hasWon)
        {
            Type collectibleType = Type.GetType("Collectibles");
            if (collectibleType != null)
            {
                int totalCollectibles = FindObjectsByType(collectibleType, FindObjectsSortMode.None).Length;

                if (totalCollectibles == 0)
                {
                    hasWon = true;
                    Instantiate(winEffect, transform.position, Quaternion.identity).Play();
                    winSound.Play();
                }
            }
        }

    }


    // Handle physics-based movement and rotation.
    private void FixedUpdate()
    {
        // Move player based on vertical input.
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        // Rotate player based on horizontal input.
        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}