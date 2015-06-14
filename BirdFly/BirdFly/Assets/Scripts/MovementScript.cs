using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{

    Animator anim;
    float maxSpeed = 5f;
    Rigidbody2D rigidBody2D;
    void Start()
    {
        anim = GetComponent<Animator>();
        //rigidBody2D = GetComponent<Rigidbody2D>();
        //transform.position = Input.mousePosition;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        print(transform.position.x + "||" + transform.position.y);
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < transform.position.x)
            {
                anim.SetBool("FlyLeft", true);
                
            }
            else if (Input.mousePosition.x > transform.position.x)
            {
                anim.SetBool("FlyRight", true);
                
            }
           
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, 1f * Time.deltaTime);

        }
       
        //float Horizontal = Input.GetAxis("Horizontal");
        //anim.SetFloat("Direction", Horizontal);
        //rigidBody2D.AddForce((Vector2.right * maxSpeed) * Horizontal);

        //if (rigidBody2D.velocity.x >= maxSpeed)
        //{
        //    rigidBody2D.velocity = new Vector2(maxSpeed, rigidBody2D.velocity.y);
        //}
    }

    public Vector3 mousePosition { get; set; }
}
