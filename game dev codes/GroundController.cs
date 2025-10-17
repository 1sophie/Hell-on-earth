public class GroundController : MonoBehaviour
{
    private float levelSpeed = 0.06f;
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * levelSpeed);
    }
}
