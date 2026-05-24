using UnityEngine;

public class LampController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("=== W key pressed - calling SetTrigger('Recolour') ===");
            animator.SetTrigger("Recolour");
        }

        if (Input.GetKeyDown(KeyCode.A))
            animator.SetTrigger("Scale");

        if (Input.GetKeyDown(KeyCode.S))
            animator.SetTrigger("Rotate");

        if (Input.GetKeyDown(KeyCode.D))
            animator.SetTrigger("Float");
    }
}