using UnityEngine;

public class Fantasma : MonoBehaviour
{
    //Atributes
    //Public

    public string nombre;
    public Juguete juguetePoseido;

    //Private

    private int _energia;

    //Methods

    public void Poseer (Juguete objetivo)
    {
        if (objetivo.estaPoseido == false)
        {
            // 1. Cambias el estado interno del juguete
            objetivo.estaPoseido = true; 
        
            // 2. ASIGNACIÓN EN MEMORIA: 
            // Le dices al fantasma que guarde este juguete en su variable de la línea 9
            juguetePoseido = objetivo;
        }
        else print ("Este objeto ya esta poseido");
    }
}
