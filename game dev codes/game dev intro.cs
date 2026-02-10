using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    void Update()
    {
        // TODO:
        // 1. Get input from Horizontal and Vertical axes
        // 2. Create a movement vector
        // 3. Move the transform based on that vector * speed * deltaTime
    }
}

// void Update()
//     {
//         float moveX = Input.GetAxis("Horizontal");
//         float moveY = Input.GetAxis("Vertical");

//         Vector3 moveDir = new Vector3(moveX, moveY, 0);
//         transform.Translate(moveDir * speed * Time.deltaTime);
//     }


