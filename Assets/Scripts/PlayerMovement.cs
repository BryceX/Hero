using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    Animator anim;
    float startSpeed = 10;
    public float currentSpeed = 100;
    //public float maxSpeed = 100;
    public string up;
    public string down;
    public string left;
    public string right;
    Rigidbody rb;

    //public float speed = 6.0F;
    //public float jumpSpeed = 8.0F;
    //public float gravity = 20.0F;
    //private Vector3 moveDirection = Vector3.zero;
    //CharacterController controller;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        //controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
         
        

         Movement();


    }

    void SetMovementDir(Rigidbody character, string key, Vector3 direction, float initSpeed, float speed)
    {
       
        if (Input.GetKey(key))
        {
            
            //if (speed < maxSpeed)
            //{
            //    speed += 25 * Time.deltaTime;
            //}
            character.velocity =(direction * Time.deltaTime*speed);
           
            character.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
            anim.SetBool("IsWalking", true);
            anim.Play("WALK00_F");
            anim.SetFloat("Speed", character.velocity.magnitude);
            

            

        };
        anim.SetFloat("Speed", character.velocity.magnitude);
        if (anim.GetFloat("Speed") <= .1)
        {
            anim.SetBool("IsWalking", false);
        }
    }

    void Movement()
    {

        SetMovementDir(rb, up, Vector3.forward, startSpeed, currentSpeed);
        SetMovementDir(rb, down, Vector3.back, startSpeed, currentSpeed);
        SetMovementDir(rb, left, Vector3.left, startSpeed, currentSpeed);
        SetMovementDir(rb, right, Vector3.right, startSpeed, currentSpeed);
        
    }
}
