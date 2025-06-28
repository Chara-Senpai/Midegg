using UnityEngine;
using System.Collections;
public class Simulation : MonoBehaviour
{

    public GameObject egg;
    public GameObject hen;
    public GameObject rooster;
    public GameObject chick;

    public int eggcount, chickcount, roostercount, hencount;

    public UI ui;

    private bool onehen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        eggspawn(Vector3.zero);

    }

    public void eggspawn(Vector3 position)
    {

        GameObject eggcrack = Instantiate(egg, position, Quaternion.identity);
        EggHatch e = eggcrack.GetComponent<EggHatch>();
        e.manager = this;
        eggcount++;
        ui.CounterUpdate(eggcount, chickcount, roostercount, hencount);

    }

    public void egghatched(Vector3 position)
    {

        eggcount--;
        chickcount++;
        ui.CounterUpdate(eggcount, chickcount, roostercount, hencount);

        GameObject chickcrack = Instantiate(chick, position, Quaternion.identity);
        Chickspawn c = chickcrack.GetComponent<Chickspawn>();
        c.manager = this;
    }

    public void Maturechick(Vector3 position, bool NowHen)
    {

        chickcount--;

        if (!onehen)
        {

            NowHen = true;
            onehen = true;

        }

        if (NowHen)
            {

                hencount++;
                GameObject hencrack = Instantiate(hen, position, Quaternion.identity);
                Henspawn h = hencrack.GetComponent<Henspawn>();
                h.manager = this;
                h.LiveHen();

            }
            else
            {

                roostercount++;
                GameObject roostercrack = Instantiate(rooster, position, Quaternion.identity);
                Roosterspawn r = roostercrack.GetComponent<Roosterspawn>();
                r.manager = this;
                r.Liverooster();

            }

        ui.CounterUpdate(eggcount, chickcount, roostercount, hencount);

    }

    public void HenLayEggs(Vector3 position, int count)
    {

        for (int i = 0; i < count; i++)
        {

            Vector3 offset = position + new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
            eggspawn(offset);

        }

    }

    public void DestroyHen()
    {

        hencount--;
        ui.CounterUpdate(eggcount, chickcount, roostercount, hencount);

    }

    public void DestroyRooster()
    {

        roostercount--;
        ui.CounterUpdate(eggcount, chickcount, roostercount, hencount);

    }
}
