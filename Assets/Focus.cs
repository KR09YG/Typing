using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Focus : MonoBehaviour
{
    public InputField nameInputField;
    void Start()
    {
        // InputField�������Ńt�H�[�J�X����
        nameInputField.Select();
    }
    
}
