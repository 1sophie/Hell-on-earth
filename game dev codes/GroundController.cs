public class GroundController : MonoBehaviour
{
    private float levelSpeed = 0.06f;
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * levelSpeed);
   // refer to the component Transform and take its position x position
        if(transform.position.x < -4f) 
        {
            transform.position = Vector3.zero;
        }
    }
}
