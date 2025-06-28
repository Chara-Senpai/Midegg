using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{

    [Header("Egg Counter")]
    public Image egg;
    public TextMeshProUGUI eggtext;

    [Header("Chick Counter")]
    public Image chick;
    public TextMeshProUGUI chicktext;

    [Header("Rooster Counter")]
    public Image rooster;
    public TextMeshProUGUI roostertext;

    [Header("Hen Counter")]
    public Image hen;
    public TextMeshProUGUI hentext;



    public void CounterUpdate(int eggs, int hens, int roosters, int chicks)
    {

        eggtext.text = eggs.ToString();
        chicktext.text = chicks.ToString();
        hentext.text = hens.ToString();
        roostertext.text = roosters.ToString();

    }
}
