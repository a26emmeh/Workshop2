using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D body;
    
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
        Vector2 velocity = body.linearVelocity;
        IsIdle = velocity.x == 0;
    }
}
