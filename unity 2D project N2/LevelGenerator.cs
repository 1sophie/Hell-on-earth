
public class PlayerController : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatforms;
    public float levelWidth = 3f;
    public float minY = 1.3f;
    public float maxY = 3f;
    private Vector3 _spawnPosition = new Vector3();
    private void Start(){
     for (int i = 0; i < numberOfPlatforms; i++){
     _spawnPosition.y += Random.Range(minY, maxY);
     _spawnPosition.x = Random.Range(-levelWidth, levelWidth);
     Instantiate(platformPrefab, _spawnPosition,Quaternion.identity);
   }
}
}
