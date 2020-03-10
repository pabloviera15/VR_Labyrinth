using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissableBallCollider : MonoBehaviour
{
    public Collider PlayerCollider;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Player)
    {
        print("Fall");
        PlayerCollider = Player.GetComponent<Collider>();
        PlayerCollider.enabled = false;
     
       
    }
}
