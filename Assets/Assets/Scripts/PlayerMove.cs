using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed = 3f;
    public int points = 1;
    public int life = 1;

    //Environment Collider
    public LayerMask mask;
    [SerializeField] private float _detectionRadius = 1f;
    private Vector3 _destination;

    Animator animator;

    //private string currentState;
    // private bool isPushing;  //add this later below per animation states  ***************  WIP
    // private bool isMoving = true;   // get this to work *****************  WIP

    void Awake()
    {
        _destination = this.transform.position;
        mask = LayerMask.GetMask("Block");
    }

    void Start()
    {

        //animator.SetBool("isMoving", true); // *******
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, _destination) < Mathf.Epsilon)  // Really really close to destination
        {
            #region Check Directions

            // if player is very close to the destination
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                if (CheckDirection(Vector3.right))
                {
                    _destination = transform.position + Vector3.right;
                }
            }
            else if (Input.GetAxisRaw("Horizontal") < 0)
            {
                if (CheckDirection(Vector3.left))
                {
                    _destination = transform.position + Vector3.left;
                }
            }

            if (Input.GetAxisRaw("Vertical") > 0)
            {
                if (CheckDirection(Vector3.up))
                {
                    _destination = transform.position + Vector3.up;
                }
            }
            else if (Input.GetAxisRaw("Vertical") < 0)
            {
                if (CheckDirection(Vector3.down))
                {
                    _destination = transform.position + Vector3.down;
                }
            }
            #endregion
        }

        else   //if distance is NOT close to zero  - MOVE
        {
            transform.position = Vector3.MoveTowards(transform.position, _destination, _speed * Time.deltaTime);
        //    animator.SetBool("isMoving", true);   // ismoving set  ********************
        }
    }



    private bool CheckDirection(Vector3 direction)
    {
        RaycastHit2D hit;

        //if there is something blocking movement in this direction, do not allow movement (return false)
        if (hit = Physics2D.Raycast(transform.position, direction, _detectionRadius, mask))   //
        {
            // if it is pushable
            if (hit.collider.CompareTag("Pushable"))
            {
                //Push block if it is able
                PushableBlock pushableBlock = hit.collider.GetComponent<PushableBlock>();

                //Insert - Set bool isPushing to drive Push Animations

                if (!pushableBlock)
                {
                    return false;
                }
                pushableBlock.Push(direction, _speed);
            }
            return false;
        }
        return true;
    }
}




//Animation States
//const string P_idle = "P_idle";

//const string P_walkDown = "P_walkDown";
//const string P_walkSide = "P_walkSide";
//const string P_walkUp = "P_walkUp";

//const string P_pushdown = "P_pushDown";
//const string P_pushSide = "P_pushSide";
//const string P_pushUp = "P_pushUp";

//const string P_idleDance = "P_idleDance";
//const string P_frozen = "P_frozen";




// void ChangeAnimationState(string newState)
//{
//    //stop the same animation from interrupting itself  #guard
//    if (currentState == newState) return;

//    //play the animation
//    animator.Play(newState);

//    // reassign the current state
//    currentState = newState;
//}



//    // movement and flip
//    Vector3 flip = transform.localScale;

//    if (Input.GetAxisRaw("Horizontal") > 0) // 

//    {
//        ChangeAnimationState(P_walkSide);
//        flip.x = -1;
//    }            
//    else if (Input.GetAxisRaw("Horizontal") < 0)
//    {
//        ChangeAnimationState(P_walkSide);
//        flip.x = 1;
//    }

//    if (Input.GetAxisRaw("Vertical") > 0)
//    {
//        ChangeAnimationState(P_walkUp);
//    }
//    else if (Input.GetAxisRaw("Vertical") < 0)
//    {
//        ChangeAnimationState(P_walkDown);
//    }

//    ChangeAnimationState(P_idle);
