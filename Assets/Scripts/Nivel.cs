using UnityEngine;

public class Nivel : MonoBehaviour
{
     //Public

     public Juguete jugueteObjetivo;

     //private
     private bool _completado;

     //Methods

     public void IndicarJuguete (Juguete indicarJuguete)
     {
          print ("Para completar el nivel, necesitas " + indicarJuguete.nombreJuguete);
     }

     public void update ()
     {
          //El if comprueba si el juguete asignado ya esta poseido
        if (jugueteObjetivo.estaPoseido == true)
        {
            _completado = true;
            print("Nivel completado");
        }
        else
        {
            print("Aun no has poseido el juguete correcto.");
        }
    }
}