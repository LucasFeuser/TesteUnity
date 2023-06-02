using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    GameObject fireball;
    // Este método é chamado quando o objeto colide com algo
    void OnCollisionEnter(Collision collision)
    {
        List<string> tags = new List<string> {
        "Enemy",
        "Plane"
        };


        // Verifica se a bola de fogo colidiu com o inimigo
        if (collision.gameObject)
        {
            for(int i = 0; i < tags.Count; i++)
            {
                var percorre = tags[i];
                if(collision.gameObject.tag == percorre)
                    Destroy(fireball);
            }
        }
        
    }

}
