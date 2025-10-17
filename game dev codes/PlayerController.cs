public class PlayerController : MonoBehaviour
{
    private Vector2 direction;
    private float speed = 5f;
    void Start()
    {
        Debug.Log("My name is RoboCode");
    }
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        transform.Translate(direction * speed * Time.deltaTime);
        Debug.Log(direction);
    }
}
