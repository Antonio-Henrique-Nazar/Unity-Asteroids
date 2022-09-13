using UnityEngine;

public class Balão : MonoBehaviour
{
    public Rigidbody2D RigidBodyBalon;
    public float velocidadeMaxima= 1.0f;
    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao*= velocidadeMaxima;
        RigidBodyBalon.velocity = direcao;
    }

    void Update()
    {
        
    }
}
