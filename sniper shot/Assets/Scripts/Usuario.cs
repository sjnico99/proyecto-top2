using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Usuario
{
    public string correoUsuario;
    public string nombreUsuario;
    public string contraseñaUsuario;
    public string ccontraseñaUsuario;

    public Usuario()
    {
        correoUsuario = PuntajeJugador.correoJugador;
        nombreUsuario = PuntajeJugador.nombreJugador;
        contraseñaUsuario = PuntajeJugador.contraseñaJugador;
        ccontraseñaUsuario = PuntajeJugador.ccontraseñaJugador;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
