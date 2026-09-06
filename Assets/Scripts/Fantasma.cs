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

    public void Poseer (Juguete juguetePoseido)
    {
        if (juguetePoseido.estaPoseido == false)
        {
            juguetePoseido.estaPoseido = true;
        }
        else print ("Este objeto ya esta poseido");
    }
}
