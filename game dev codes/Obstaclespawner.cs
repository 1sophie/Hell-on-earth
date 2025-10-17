public class ObstacleSpawner : MonoBehaviour
{
    public GameObject ObstacleObject;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0, 2);
    }
    private void SpawnObstacle()
    {
       Instantiate(ObstacleObject, transform.position, Quaternion.identity);
    }

}

