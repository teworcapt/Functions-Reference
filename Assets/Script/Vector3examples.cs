using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Emovment
{
    Forward,
    Backward,
    Left,
    Right
}

public class Vector3examples : MonoBehaviour
{
    public float moveSpeed;
    public Emovment movementType;
    public Transform pointA, pointB;
    public float rangeValue;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //switch (movementType)
        //{
        //    case Emovment.Forward:
        //        break;
        //    case Emovment.Backward:
        //        break;
        //    case Emovment.Left:
        //        break;
        //    case Emovment.Right:
        //        break;
        //    default:
        //        break;
        //}

        //transform.position = Vector3.Lerp(transform.position, pointB.position, moveSpeed * Time.deltaTime).normalized;

       float dist =  Vector3.Distance(transform.position, pointB.position);
      
        if (dist < rangeValue )
        {
            Debug.Log("Point B has been detected");
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangeValue);
    }

    public void MoveForward()
    {
        transform.position = Vector3.forward * moveSpeed * Time.time;
    }   
    
    public void MoveBackward()
    {
        transform.position = Vector3.back * moveSpeed * Time.time;
    }    
    
    public void MoveLeft()
    {
        transform.position = Vector3.left * moveSpeed * Time.time;
    }    
    
    public void MoveRight()
    {
        transform.position = Vector3.right * moveSpeed * Time.time;
    }
}
