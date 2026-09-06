using UnityEngine;

public class Nivel : MonoBehaviour
{
     //Public

     public Juguete jugueteObjetivo;

     //private
     private float _tiempoLimite;
     private bool _completado;

     //Methods

     public void IndicarJuguete (Juguete jugueteObjetivo)
     {
          print ("Para completar el nivel, necesitas " + jugueteObjetivo.nombreJuguete);
     }
}
