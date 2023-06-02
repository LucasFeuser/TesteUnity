using UnityEngine;

using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayAnimation();
        }
    }

    private void PlayAnimation()
    {
        animator.SetTrigger("FiringRifle"); // Troque "PlayAnimation" pelo nome do par�metro da sua anima��o
    }
}