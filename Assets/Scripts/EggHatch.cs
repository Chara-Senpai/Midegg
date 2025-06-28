using System.Collections;
using UnityEditor;
using UnityEngine;

public class EggHatch : MonoBehaviour
{

    public Simulation manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(Hatch());

    }

    IEnumerator Hatch()
    {

        yield return new WaitForSeconds(10f);
        manager.egghatched(transform.position);
        Destroy(gameObject);

    }
}
