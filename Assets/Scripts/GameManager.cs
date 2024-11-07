using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static int vidas = 3;
    public static bool playGame = true;
    public TextMeshProUGUI vidasTexto;
    public TextMeshProUGUI gameOvertxt;
    // Start is called before the first frame update
    void Start()
    {
        vidasTexto.text = "Vidas: " + vidas;
    }

    // Update is called once per frame
    void Update()
    {
        vidasTexto.text = "Vidas: " + vidas;

        if (vidas==0)
        {
            gameOvertxt.text = "GAME OVER";
        }
    }
}
