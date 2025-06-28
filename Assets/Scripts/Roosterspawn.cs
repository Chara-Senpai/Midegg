using System.Collections;
using UnityEditor;
using UnityEngine;

public class Roosterspawn : MonoBehaviour
{

    public Simulation manager;

    public void Liverooster()
    {

        StartCoroutine(Lifecycle());

    }

    IEnumerator Lifecycle()
    {

        yield return new WaitForSeconds(40f);
        manager.DestroyRooster();
        Destroy(gameObject);

    }

}
