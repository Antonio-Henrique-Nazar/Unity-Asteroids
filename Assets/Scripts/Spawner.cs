using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Balão prefabBalão;
    public int Quantidade=3;
    void Start()
    {
        for(int i=0;i<Quantidade;i++){
            float x= Random.Range(-15.0f,15.0f);
            float y= Random.Range(-7.0f,7.0f);
            Vector3 posicao= new Vector3(x,y,0.0f);
            Instantiate(prefabBalão,posicao,Quaternion.identity);
        }
    }
    void Update()
    {
        
    }
    void 
}
