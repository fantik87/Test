using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lobby : MonoBehaviour
{
    [SerializeField] private Canvas FirstScreen;
    [SerializeField] private Canvas SecondScreen;



    void Start()
    {
        SecondScreen.enabled = false;
    }

    public void CreateRoom()
    {
        SecondScreen.enabled = true;
        FirstScreen.enabled = false;
    }

    public void EnterRoomName()
    {

    }



    void Update()
    {
        
    }
}
