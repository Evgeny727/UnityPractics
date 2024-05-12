using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Netcode;

public class GameHelper : NetworkBehaviour
{
    public TMP_InputField InputField;
    public TMP_Text TextField;

    [Rpc(SendTo.Server)]
    public void PingRpc(string message)
    {
        PongRpc(message);
    }

    [Rpc(SendTo.ClientsAndHost)]
    void PongRpc(string message)
    {
        Debug.Log($"Received pong from server with message = " + message);
        TextField.text = TextField.text + "\n" + message;
    }

    public  void Send()
    {
        string message = InputField.text;
        InputField.text = null;
        PingRpc(message);
    }
}
