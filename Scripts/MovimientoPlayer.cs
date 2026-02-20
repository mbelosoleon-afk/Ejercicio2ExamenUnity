using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class MovimientoPlayer : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 10.0f;
    public Transform objetivo;
    public float distanciaLimite = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove (InputValue movementValue)
    {
        // tomar valores del InputSystem
        Vector2 movementVector = movementValue.Get<Vector2>();
        // actualizar los valores de fuerza/movimiento
        movementX = movementVector.x; 
        movementY = movementVector.y; 
        
    }
    
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3 (speed*movementX, 0.0f , speed*movementY);
        
        rb.AddForce(movement);

        if (objetivo != null)
        {
            float distancia = Vector3.Distance(transform.position, objetivo.position);
            
            if (distancia < distanciaLimite)
            {
                Debug.Log("Estado: CERCA del cubo");
            }
            else
            {
                Debug.Log("Estado: LEJOS del cubo");
            }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Debug.Log("El jugador y el Enemigo están colisionando");
        }
    }
    
}
