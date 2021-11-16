using System;
using UnityEngine;
using Zork.Common;
using TMPro;

public class UnityInputService : MonoBehaviour, IInputService
{
    public event EventHandler<string> InputReceived;

    [SerializeField]
    private TMP_InputField InputField;

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            string inputString = InputField.text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(inputString) == false)
            {
                InputReceived?.Invoke(this, inputString);
            }

            InputField.text = string.Empty; // clears text field once player has hit ENTER
        }
    }

}
