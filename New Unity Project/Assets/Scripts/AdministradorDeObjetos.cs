using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorDeObjetos : MonoBehaviour
{
    public GameObject menuAjustes;

    void Start()
    {
        menuAjustes.gameObject.SetActive(false);
        
    }

    public void OcultarMenuInicial(GameObject menuInicial){
        menuInicial.gameObject.SetActive(false);
    }
    
    public void AparecerMenuAjustes(GameObject menuAjustes){
        menuAjustes.gameObject.SetActive(true);
    }

    public void OcultarMenuAjustes(GameObject menuAjustes){

        menuAjustes.gameObject.SetActive(false);
    }
    public void AparecerMenuInicial(GameObject menuInicial){

        menuInicial.gameObject.SetActive(true);
    }




}
