using UnityEngine;

public float jumpForce = 10f;

private void OnCollisionEnter2D(Collision2D collision)
{
   // If the relative velocity is 0 or less
   if (collision.relativeVelocity.y <= 0f)
   {
       // get a reference to the component
       Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
       // if we received the package, it is a collision with the object we need
       if (playerRb != null)
       {
           // set the direction and add acceleration to our game object
           playerRb.velocity=Vector2.up*jumpForce;
       } 
   }
}
