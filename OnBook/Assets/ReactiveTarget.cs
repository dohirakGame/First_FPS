using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    void Start()
    {
        WanderingAI behavior = GetComponent<WanderingAI>();
        if (behavior != null)
        {
            behavior.SetAlive(false);
        }
    }

    public void ReactToHit()
    {
        
        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        this.transform.Rotate(-75,0,0);

        yield return new WaitForSeconds(1.5f);

        Destroy(this.gameObject);
    }
}
