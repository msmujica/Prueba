using System;
using System.Collections.Generic;
using System.Windows.Markup;

namespace Library;

/// <summary>
/// Clase que representa un Pokémon con nombre, puntos de vida, lista de ataques, tipo y estado de derrota.
/// Permite recibir daño, realizar ataques y gestionar su estado de derrota.
/// La clase Pokemon aplica los siguientes principios:
/// •	Expert: Pokemon gestiona su propia vida, ataques y estado, siguiendo el principio de asignar responsabilidades al experto en la información.
/// •	Acoplamiento bajo: Utiliza GestorEfectos para manejar efectos adicionales en los ataques, manteniendo bajo el acoplamiento con otras clases.
/// •	OCP (Open-Closed Principle): Permite la extensión con nuevas interfaces y funcionalidades, sin modificar el código existente.
/// </summary>

public class Pokemon
{
    private string nombre;
    private int vida;
    private List<string> ataques;
    private string tipo;
    private bool estaDerrotado;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    public List<string> Ataques
    {
        get { return ataques; }
        set { ataques = value; }
    }

    public string Tipos
    {
        get { return tipo; }
        set { tipo = value; }
    }

    public bool EstaDerrotado
    {
        get { return estaDerrotado; }
        set { estaDerrotado = value; }
    }
    
    /// <summary>
    /// Constructor de la clase Pokémon.
    /// </summary>
    /// <param name="nombre">Nombre del Pokémon.</param>
    /// <param name="vida">Puntos de vida iniciales del Pokémon.</param>
    /// <param name="ataques">Lista de ataques que puede realizar el Pokémon.</param>
    /// <param name="tipo">Tipo o tipos del Pokémon.</param>
    public Pokemon(string nombre, int vida, List<string> ataques, string tipo)
    {
        this.Nombre = nombre;
        this.Vida = vida;
        this.Ataques = ataques;
        this.Tipos = tipo;
        this.EstaDerrotado = false;
    }

    /// <summary>
    /// Método que permite al Pokémon recibir un cierto daño.
    /// </summary>
    /// <param name="daño">Cantidad de daño recibido.</param>
    public void recibirDaño(int daño)
    {
        if (!this.EstaDerrotado)
        {
            this.Vida -= daño;
            if (this.Vida <= 0)
            {
                this.EstaDerrotado = true;
                this.Vida = 0;
                Console.WriteLine($"{this.Nombre} a sido derrotado");
            }
        }
        else
        {
            Console.WriteLine($"{this.Nombre} no puede recibir daño por que ya a sido derrotado");
        }
    }

    /// <summary>
    /// Método que permite al Pokémon realizar un ataque sobre otro Pokémon.
    /// </summary>
    /// <param name="oponente">Pokémon sobre el cual se realizará el ataque.</param>
    /// <param name="ataque">Nombre del ataque que se realizará.</param>
    /// <param name="gestorEfectos">Gestor de efectos para calcular el daño del ataque.</param>
    /// <returns>El valor del daño causado al oponente como una cadena.</returns>
    public string atacar(Pokemon oponente, string ataque, GestorEfectos gestorEfectos)
    {
        foreach (var VARIABLE in this.Ataques)
        {
            if (VARIABLE == ataque)
            {
                int valor = Ataque.CalcularDaño(ataque, oponente, gestorEfectos);
                oponente.recibirDaño(valor);
                return valor.ToString();
            }
        }

        return "Flaco este no es tu ataque";
    }
}