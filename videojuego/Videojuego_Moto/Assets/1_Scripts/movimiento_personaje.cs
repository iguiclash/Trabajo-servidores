using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movimiento_personaje: MonoBehaviour
{

    public float moveSpeed = 5f; // Velocidad de movimiento del personaje
    public float jumpForce = 10f; // Fuerza del salto

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento horizontal
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        // Saltar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}