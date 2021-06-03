using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

public class PuntajeJugador : MonoBehaviour
{
    public InputField textoCorreo;
    public InputField textoNombre;
    public InputField textoContraseña;
    public InputField textoCcontraseña;


    public static string correoJugador;
    public static string nombreJugador;
    public static string contraseñaJugador;
    public static string ccontraseñaJugador;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enviar()
    {
        correoJugador = textoCorreo.text;
        nombreJugador = textoNombre.text;
        contraseñaJugador = textoContraseña.text;
        ccontraseñaJugador = textoCcontraseña.text;

        enviarPorPOST();
    }

    public void enviarPorPOST()
    {
        Usuario usuario = new Usuario();
        RestClient.Post("https://snipershot-55721-default-rtdb.firebaseio.com/.json", usuario);
    }
}
