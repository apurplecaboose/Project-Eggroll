using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerStats PlayerStats;
    public SpriteRenderer SpriteCranberry;
    //Varibles
    float playerHeight = 1f;
    private float SidewaysInput;
    private float ForwardsInput;
    public bool isGrounded;
    public float PlayerSpeed;

    //Raycasts
    public RaycastHit GroundedRay;

    public Animator ani;
    public Rigidbody rb;

    private void Start()
    {
        rb.freezeRotation = true;
    }
    /**************************************/
    public void Update()
    {
        SunshineRays();
        ControlDrag();
        SidewaysInput = Input.GetAxisRaw("Horizontal");
        ForwardsInput = Input.GetAxisRaw("Vertical");
        print(ForwardsInput);

        ////flipscript
        if (SidewaysInput > 0f)
            SpriteCranberry.flipX = false;
        else if (SidewaysInput < 0f)
            SpriteCranberry.flipX = true;
    }
    void SunshineRays()
    {    
        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight / 2 + 1f);
    }
    void ControlDrag()
    {
       rb.drag = PlayerStats.drag;
    }
    private void FixedUpdate()
    {
        MovePlayer();
        Gravity();
    }
    void MovePlayer()
    {   
        if (SidewaysInput != 0)
        {
            rb.AddForce(PlayerStats.moveSpeed * SidewaysInput * PlayerStats.speedMultiplier * transform.right, ForceMode.Acceleration);
        }
        if(ForwardsInput !=0)
        {
            rb.AddForce(PlayerStats.moveSpeed * ForwardsInput * PlayerStats.speedMultiplier * transform.forward, ForceMode.Acceleration);
        }
    }
    void Gravity()
    {
            rb.AddForce(Vector3.down * PlayerStats.Grav * PlayerStats.speedMultiplier, ForceMode.Acceleration);
    }

    private void LateUpdate()
    {
    ani.SetFloat("SideMotion", Mathf.Abs(SidewaysInput) - ForwardsInput);
    
    if (ForwardsInput>0.1)
        {
            ani.SetBool("MovingBack", true);
        }
    else ani.SetBool("MovingBack", false);
    }
}
