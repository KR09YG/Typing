using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Focus : MonoBehaviour
{
    public InputField nameInputField;
    void Start()
    {
        // InputFieldを自動でフォーカスする
        nameInputField.Select();
    }
    
}
