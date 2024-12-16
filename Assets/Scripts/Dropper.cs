using UnityEngine;

public class Dropper : MonoBehaviour
{
    
    [SerializeField] float TimeToWait = 2f;

    MeshRenderer MyMeshRenderer;
    Rigidbody MyRigidBody;

    void Start()
    {
        MyMeshRenderer = GetComponent<MeshRenderer>();
        MyMeshRenderer. enabled = false;

        MyRigidBody = GetComponent<Rigidbody>();
        MyRigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > TimeToWait)
        {
            MyMeshRenderer. enabled = true;
            MyRigidBody.useGravity = true;
        }
    }
}
