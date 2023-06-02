using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpeel : MonoBehaviour
{
    GameObject fireballPrefab, fireball; // Referência ao prefab da bola de fogo
    float fireballSpeed = 10.0f; // Velocidade da bola de fogo
    Collision collision;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Cria a bola de fogo
            fireball = Instantiate(fireballPrefab, transform.position, transform.rotation);

            // Lança a bola de fogo
            Rigidbody rb = fireball.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * fireballSpeed;
            OnCollisionEnter(collision, fireball);
        }
    }

    void OnCollisionEnter(Collision collision, GameObject fireball)
    {
        List<string> tags = new List<string> {
        "Enemy",
        "Plane"
        };


        // Verifica se a bola de fogo colidiu com o inimigo
        if (collision.gameObject)
        {
            for (int i = 0; i < tags.Count; i++)
            {
                var percorre = tags[i];
                if (collision.gameObject.tag == percorre)
                    Destroy(fireball);
            }
        }

    }
}
