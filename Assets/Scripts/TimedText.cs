using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimedText : MonoBehaviour
{
    public TMP_Text ChosenText;
    public float Duration = 1f;
    
    void Start()
    {
        ChosenText.gameObject.SetActive(false);
    }

    void OnCollisionEnter()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        ChosenText.gameObject.SetActive(true);
        
        yield return new WaitForSeconds(Duration);

        ChosenText.gameObject.SetActive(false);
    }
}
