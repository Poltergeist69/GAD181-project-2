using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float rayLength =5.0f;
    public LayerMask PlayerMask;
    
    void Start()
    {
        
    }
    void Update()
    {
        targetPlayer();
    }
    void targetPlayer()
    {
        RaycastHit2D targetPoint = (Physics2D.Raycast(transform.position, Vector2.left, rayLength,PlayerMask));
        if (targetPoint.collider!=null&&targetPoint.collider.tag=="Player")
        {
            Debug.Log("player is found");
        }
        else
        {
            return;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay (transform.position, Vector2.left*rayLength);
    }

}







