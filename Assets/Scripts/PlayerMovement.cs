using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveHorizontal != 0.0f || moveVertical != 0.0f)
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            transform.position += movement * speed * Time.deltaTime;
        }

        // Faz o personagem permanecer de pé
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
    }

}
