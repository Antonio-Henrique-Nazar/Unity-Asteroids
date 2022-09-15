using UnityEngine;

public class Balão : MonoBehaviour
{
    public static System.Action EventoBalãoDestruido=null;
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
    void OnTriggerEnter2D(Collider2D outro){
        Destroy(gameObject);
        Destroy(outro.gameObject);
        if(EventoBalãoDestruido!=null){
            EventoBalãoDestruido();
        }
    }
}
