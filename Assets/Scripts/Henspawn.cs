using System.Collections;
using UnityEngine;

public class Henspawn : MonoBehaviour
{

    public Simulation manager;

    public void LiveHen()
    {

        StartCoroutine(Lifecycle());

    }

    IEnumerator Lifecycle()
    {

        yield return new WaitForSeconds(30f);
        int eggs = Random.Range(2, 11);
        manager.HenLayEggs(transform.position, eggs);

        yield return new WaitForSeconds(20f);
        manager.DestroyHen();
        Destroy(gameObject);

    }

}
