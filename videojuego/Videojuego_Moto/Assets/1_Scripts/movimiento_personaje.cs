using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movimiento_personaje: MonoBehaviour
{

    public float jumpForce = 10f; // Fuerza del salto
    public bool isGrounded = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isGrounded)
       {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            Debug.Log("patat saltando :D");
        }
    }
  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Marcar como en el suelo al colisionar con el suelo.
            Debug.Log("colision en suelo");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
        Debug.Log("descolisiona con el suelo (dios que palabro he puesto)");
    }
}


   
