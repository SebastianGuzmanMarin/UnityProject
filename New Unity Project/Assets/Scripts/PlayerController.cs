using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float HorizontalMove;
    public float VerticalMove;
    public CharacterController Player;


    void Start()
    { Player = GetComponent<CharacterController>();
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {
        
    }
}
