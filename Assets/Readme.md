Para este ejercicio, hay que crear dos Scritps.
Uno que sea para el movimiento del jugador y otro el del enemigo.

Para el primer apartado, debemos añadir un método para que avise de que
los dos objetos están colisionando

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Debug.Log("El jugador y el Enemigo están colisionando");
        }
    }

Y para el segundo apartado, en el método FIxedUpdate, debemos añadir dos
nuevas variabñes y el siguiente
código obtener las distancias.

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