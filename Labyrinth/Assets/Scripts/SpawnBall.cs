using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using OVRTouchSample;

public class SpawnBall : MonoBehaviour
{
    public GameObject placeHolder;
    public GameObject myPrefav;
    // Start is called before the first frame update
    void Start()
    {
        InputActions spawn = new InputActions();

        spawn.Enable();

        spawn.Player.Respawn.performed += Respawn_performed;
    }

    private void Respawn_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        Instantiate(myPrefav, placeHolder.transform.position, Quaternion.identity);
        Debug.Log("nbxodhfbxfidgbjk");
    }

    // Update is called once per frame
    void Update()
    {
    }

    

}
