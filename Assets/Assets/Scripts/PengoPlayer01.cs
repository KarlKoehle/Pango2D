using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PengoPlayer01 : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Transform movePoint;
    public LayerMask whatStopsMovement;
    public int points;

    Animator myAnim;
   // SpriteRenderer mySpriteRen;


    public bool isMoving;
    public bool facingRight;
    public bool facingUp;


    void Start()
    {
        movePoint.parent = null;
      //  mySpriteRen = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();

    }
  
    void Update()
    {
        // Player Movement and check for env collisions
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint.position) <= Mathf.Epsilon)  //previously .02f
        {
            bool isMoving = false;
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                isMoving = true;    //Set to isMoving  Set to horizontal move

                //if (Input.GetAxisRaw("Horizontal") > 0)
                //{
                //    myAnim.SetBool("facingRight", facingRight = true);
                //    //FlipX();
                //}

                //if (Input.GetAxisRaw("Horizontal") < 0)
                //{
                //    //FlipX();     
                //}


                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal") / 2, 0f, 0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal") / 2, 0f, 0f);
                }
            }

            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                isMoving = true;   //Set to isMoving  Set to Vertical move

                //if (input.getaxisraw("vertical") > 0)
                //{
                //    myanim.setbool("facingup", facingup = true);
                //}

                //if (input.getaxisraw("vertical") < 0)
                //{
                //    myanim.setbool("facingup", facingup = false);
                //}

                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical") / 2, 0f), .3f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical") / 2, 0f);
                }
            }
            myAnim.SetBool("isMoving", isMoving);
        }
     }

    //void FlipX()
    //{
    //    facingRight = !facingRight;
    //    mySpriteRen.flipX = !mySpriteRen.flipX;
    //}
}




/*   Declaration 
Global variables

    //   bool facingUp = true;
    //   bool facingRight = true;

    // public float moveX;
    // public float moveY;

    //   Rigidbody2D myRB;
    //   SpriteRenderer myRenderer;
    //   Animator myAnim;


void Start()

 // myRB = GetComponent<Rigidbody2D>();
       // myRenderer = GetComponent<SpriteRenderer>();
       // myAnim = GetComponent<Animator>();
       // moveX = Input.GetAxis("Horizontal");
      //  moveY = Input.GetAxis("Vertical");




/* 
       // Flip horizontal or Vertical

       if (moveX > 0 && !facingRight)
           FlipX();
       else if (moveX < 0 && facingRight)
           FlipX();

       if (moveY > 0 && !facingUp)
           FlipY();
       else if (moveY < 0 && facingUp)
       {
           FlipY();
       }

*/





/*       void FlipX()
       {
           facingRight = !facingRight;
           myRenderer.flipX = !myRenderer.flipX;
       }

       void FlipY()
       {
           facingUp = !facingUp;
           myAnim.SetBool("facingUp", facingUp);
       }



 // print(moveX);
       // print(moveY);

*/