using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIPontuação : MonoBehaviour
{
    public TMP_Text textoScore;
    public int pontuacao=0;
    void Awake(){
        textoScore.text="";
        Balão.EventoBalãoDestruido += BalãoFoiDestruido;
    }
    void OnDestroy(){
         Balão.EventoBalãoDestruido -= BalãoFoiDestruido;
    }
    void BalãoFoiDestruido(){
        pontuacao+=100;
        AtualizaTextoScore();
    }
    void AtualizaTextoScore(){
        textoScore.text = pontuacao.ToString();
    }
}
