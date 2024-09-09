using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFIledTest : MonoBehaviour
{
    [SerializeField] Text text1;
    public void Test(string text)
    {
        text1.text = text;
    }
}
