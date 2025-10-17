public class PlayerController : MonoBehaviour
{
    private Vector2 direction;
    private float speed = 5f;
    private float jumpForce = 8f;
    private Rigidbody2D rb2d;
    private void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
