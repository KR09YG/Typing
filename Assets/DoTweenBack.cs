using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class DoTweenBack : MonoBehaviour
{
    Image image;
    void Start()
    {
        image = GetComponent<Image>();
        image.DOFade(0f, 10f);
    }

}
