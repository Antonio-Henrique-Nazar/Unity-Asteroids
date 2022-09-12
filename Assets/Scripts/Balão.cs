using UnityEngine;

public class Balão : MonoBehaviour
{
    public Rigidbody2D RigidBodyBalon;

    void Start()
    {
        RigidBodyBalon.velocity = new Vector2(1.0f,0.0f);
    }

    void Update()
    {
        
    }
}
