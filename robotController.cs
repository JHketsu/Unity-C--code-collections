using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotController : MonoBehaviour
{
    private Rigidbody2D Robo;
    private Animator anim;
    public float MoveSpeed;
    public float JumpHeight;
    
    void Move(){

        float speed = Input.GetAxis("Horizontal")*MoveSpeed;
        if (speed>0)
        {
            anim.SetBool("isLeft",false);
            anim.SetBool("isRight",true);
            Robo.velocity = new Vector2(speed, Robo.velocity.y);
        }
        else if(speed<0)
        {
            anim.SetBool("isLeft",true);
            anim.SetBool("isRight",false);
            Robo.velocity = new Vector2(speed, Robo.velocity.y);
            
        }
        else{
            anim.SetBool("isLeft",false);
            anim.SetBool("isRight",false);
        }

        if (Input.GetKey(KeyCode.A)){
            transform.localScale = new Vector3(-0.1725f, 0.1725f, 0.1725f);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.localScale = new Vector3(0.1725f, 0.1725f, 0.1725f);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isLeft",false);
        anim.SetBool("isRight",false);
    }

    void Awake()
    {
        Robo = transform.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
             Robo.velocity = new Vector2(Robo.velocity.x, JumpHeight);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
