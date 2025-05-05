using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClassManager : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputClave;
    string claveCorrecta = "fogolin";
    string claveIngresada;

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void verificarClave()
    {
        claveCorrecta = inputClave.text;
        if (claveIngresada == claveCorrecta)
        {
            txtResultado.text = "clave correcta";
        }
        else
        {
            txtResultado.text = "clave incorrecta";
        }

    }
}
