using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    float velocity = 0.0f;
    public float acceleration = 0.2f;
    public float deceleration = 0.5f;
    int VelocityHash;
    int VelocityHashX;
    int VelocityHashY;
    int JumpHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        VelocityHash = Animator.StringToHash("Velocity");
        VelocityHashX = Animator.StringToHash("XSpeed");
        VelocityHashY = Animator.StringToHash("YSpeed");
        JumpHash = Animator.StringToHash("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        bool y = Input.GetKey(KeyCode.Space);
        Vector3 move = new Vector3(x, 0, z);
        if (move.magnitude > 0.0f)
        {
            //animator.SetBool("Moving", true);

            velocity += Time.deltaTime * acceleration;
        }

        if (move.magnitude < 0.1f)
        {
            //animator.SetBool("Moving", false);

            velocity -= Time.deltaTime * deceleration;

            velocity = 0.0f;
        }
        if(y)
            animator.SetTrigger(JumpHash);
        animator.SetFloat(VelocityHash, velocity);
        animator.SetFloat(VelocityHashX, x);
        animator.SetFloat(VelocityHashY, z);
        
    }
}
