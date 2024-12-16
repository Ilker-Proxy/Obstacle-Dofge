using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    private void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
        
    }

    void Update()
    {
        moveToPlayer();
        DestroyWhenReached();
    }
    void moveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }
    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);    
        }
        
    }
}
    
