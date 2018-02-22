using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float JetPackForce = 100;
    public float WalkForce = 10;
    public float MaxWalkSpeed = 2;
    private bool isJumping = false;
    public Transform GroundCheck;
    public GameObject spriteplayer;
    // Use this for initialization
    void Start()
    {


    }
    bool GetGrounded()
    {
        return Physics2D.Linecast(transform.position, GroundCheck.position, LayerMask.GetMask("walls"));
    }

    // Update is called once per frame

    void Update()
    {

        Vector2 mouse = Input.mousePosition;
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouse);

        Vector2 armToMouse = mouseWorldPosition - transform.position;
        if (armToMouse.x < 0)
        {
            spriteplayer.transform.localScale = new Vector3(-1, 1, 1);

        }
        else
        {
            spriteplayer.transform.localScale = new Vector3(1, 1, 1);
        }
    }
    void FixedUpdate()
    {
        Animator a = spriteplayer.GetComponent<Animator>();
        a.SetFloat("walk_Speed", GetComponent<Rigidbody2D>().velocity.magnitude);

        if (isJumping && GetGrounded())
        {
            isJumping = false;
            a.SetBool("isJumping", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && GetGrounded() && !isJumping)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * JetPackForce);
            isJumping = true;
            a.SetBool("isJumping", true);
        }        

        if (Input.GetKey(KeyCode.LeftArrow) && (GetComponent<Rigidbody2D>().velocity.magnitude < MaxWalkSpeed))
        {
            GetComponent<Rigidbody2D>().AddForce(-Vector2.right * WalkForce);
        }
        if (Input.GetKey(KeyCode.RightArrow) && (GetComponent<Rigidbody2D>().velocity.magnitude < MaxWalkSpeed))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * WalkForce);

        }
    }
}
