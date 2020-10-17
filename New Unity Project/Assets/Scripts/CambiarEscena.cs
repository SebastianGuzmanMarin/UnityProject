using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//libreria para usar el cambio de escena

public class CambiarEscena : MonoBehaviour
{
    public void CambiarDeEscena(string NombreEscena){
        SceneManager.LoadScene(NombreEscena);
    }
 
        
    
}
