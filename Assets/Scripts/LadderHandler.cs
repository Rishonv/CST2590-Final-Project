/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderHandler : MonoBehaviour
{
     private bool onWall;
     private bool onRightWall;
     private bool onLeftWall;
     private float CollRad;
     private Vector2 rightOffset;
     private Vector2 leftOffset;
     private Vector2 groundOffset;
     private LayerMask groundLayer;
     private int side;

     void Update()
     {
         onWall = Physics2D.OverlapCircle((Vector2)transform.position +
                 rightOffset, CollRad, groundLayer) ||
                 Physics2D.OverlapCircle((Vector2)transform.position +
                 leftOffset, CollRad, groundLayer);
         onRightWall = Physics2D.OverlapCircle((Vector2)transform.position +
                 rightOffset, CollRad, groundLayer);
         onLeftWall = Physics2D.OverlapCircle((Vector2)transform.position +
                 rightOffset, CollRad, groundLayer);
         side = onRightWall ? 1 : -1;
     }

     private void OnDrawGizmos()
     {
         Gizmos.color = Color.red;
         Gizmos.DrawWireSphere((Vector2)transform.position + rightOffset, CollRad);
         Gizmos.DrawWireSphere((Vector2)transform.position + leftOffset, CollRad);
     } 

}*/
