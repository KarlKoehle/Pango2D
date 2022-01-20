using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableBlock : MonoBehaviour
{
    public Vector3 _destination;
    private float _speedMultiplier = 1.2f;
    public bool _isBeingPushed;

    [SerializeField] private float _speed = 3f;
    [SerializeField] private float _detectionRadius = .5f;

    public LayerMask mask;


    private void Awake()
    {
        _destination = this.transform.position;
        mask = LayerMask.GetMask("Block");
    }

    void Start()
    {
     
    }


    void Update()
    {
        //if very close to destination
        if (Vector3.Distance(transform.position, _destination) < Mathf.Epsilon)
        {
            transform.position = _destination;
            _isBeingPushed = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _destination, _speed * Time.deltaTime);
        }
    }

    private bool CheckDirection(Vector3 direction)
    {
        // If there is something blockingmovement in this direction, do not allow movement (return false)
        if (Physics2D.Raycast(transform.position + direction *.5f, direction, _detectionRadius, mask))

        {
            return false;
        }

        return true;
    }


    public void Push(Vector3 direction, float speed)
    {
        if (!_isBeingPushed)
        {
            if (CheckDirection(direction))
            {
                _destination = transform.position + direction;
                _speed = speed * _speedMultiplier;
                _isBeingPushed = true;
            }
        }
    }







}
