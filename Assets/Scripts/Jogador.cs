using UnityEngine;

public class Jogador : MonoBehaviour
{ 
    public Rigidbody2D RigidbodyJogador;
    public float aceleracao;
    public float veolcidadeAngular = 180.0f;
    public float velocidadeMaxima = 5.0f;
    public Rigidbody2D prefabProjetil;
    public float velocidadeprojetil= 10.0f;
    void Start()
    {
        
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            Rigidbody2D projetil = Instantiate(prefabProjetil,RigidbodyJogador.position,Quaternion.identity);
            projetil.velocity = transform.up*velocidadeprojetil;
        }
        
    }

    void FixedUpdate()
    {
        Vector3 direcao = transform.up * aceleracao;
        if(Input.GetKey(KeyCode.UpArrow)){
            RigidbodyJogador.AddForce(direcao,ForceMode2D.Force);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            RigidbodyJogador.rotation += veolcidadeAngular *Time.deltaTime;
        }
         if(Input.GetKey(KeyCode.RightArrow)){
            RigidbodyJogador.rotation -= veolcidadeAngular *Time.deltaTime;
        }
        if(RigidbodyJogador.velocity.magnitude > velocidadeMaxima){
            RigidbodyJogador.velocity = Vector2.ClampMagnitude(RigidbodyJogador.velocity,
            velocidadeMaxima);
        }
    }
    void OnTriggerEnter2D(Collider2D outro){
        
        Destroy(gameObject);
        Debug.Log("Fui destruido");
    }
}
