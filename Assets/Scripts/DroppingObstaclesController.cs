using UnityEngine;

public class DroppingObstaclesController : MonoBehaviour
{
    MeshRenderer obstacleRenderer;
    Rigidbody obstacleRigidbody;

    [SerializeField]
    float timeToDrop;

    void Start() 
    {
        obstacleRenderer = GetComponent<MeshRenderer>();
        obstacleRenderer.enabled = false;

        obstacleRigidbody = GetComponent<Rigidbody>();
        obstacleRigidbody.useGravity = false;
    }

    void Update()
    {
        DropObstacle();
    }

    void DropObstacle()
    {
        if(Time.time > timeToDrop)
        {
            obstacleRenderer.enabled = true;
            obstacleRigidbody.useGravity = true;
        }
    }
}
