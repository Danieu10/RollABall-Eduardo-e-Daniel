using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class condicaovitoria : MonoBehaviour
{
    public static condicaovitoria instance;


    public TextMeshProUGUI vitoria;
    public TextMeshProUGUI pontuacaotexto;

    int pontuacao = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        vitoria.text = "";
        
    }

    private void Update()
    {
        pontuacaotexto.text = "Pontuação: " + pontuacao.ToString();

        if(pontuacao==12)
        {
            vitoria.text = "VOCÊ VENCEU. ASSALTASTES O BANCO!";
        }
    }

    public void somaponto()
    {
        pontuacao = pontuacao + 1;

    }

}
