using System.Collections;
using UnityEditor;
using UnityEngine;

public class Chickspawn : MonoBehaviour
{

    public Simulation manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(Maturity());

    }

    IEnumerator Maturity()
    {

        yield return new WaitForSeconds(10f);
        bool NowHen = Random.value < 0.5f;
        manager.Maturechick(transform.position, NowHen);
        Destroy(gameObject);
        
    }
}
