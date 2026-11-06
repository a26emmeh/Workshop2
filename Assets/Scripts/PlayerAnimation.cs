using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rigidbody2D;
    
    private bool IsIdle
    {
        get => animator.GetBool("Idle");
        set  => animator.SetBool("Idle", value);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        IsIdle = true;
    }

    // Update is called once per frame
    public void Update()
    {
        // isIdle = true;
        Vector2 velocity = rigidbody2D.linearVelocity;
        Debug.Log(velocity);
        IsIdle = velocity.x == 0;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // IsIdle = false;
    }
}
