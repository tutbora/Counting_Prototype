using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;
    public Text CounterBlue;
    public Text CounterGreen;
    public Text CounterRed;
    public Text CounterWhite;

    private int Count = 0;
    private int CountBlue = 0;
    private int CountGreen = 0;
    private int CountRed = 0;
    private int CountWhite = 0;

    private void Start()
    {
        Count = 0;
        CountBlue = 0;
        CountGreen = 0;
        CountRed = 0;
        CountWhite = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Count : " + Count;
        if (other.tag.Contains("Red")) {
            CountRed += 1;
            CounterRed.text = "Red : " + CountRed;
        } else if (other.tag.Contains("Blue")) {
            CountBlue += 1;
            CounterBlue.text = "Blue : " + CountBlue;
        } else if (other.tag.Contains("Green")) {
            CountGreen += 1;
            CounterGreen.text = "Green : " + CountGreen;
        } else if (other.tag.Contains("Blue")) {
            CountBlue += 1;
            CounterBlue.text = "Blue : " + CountBlue;
        } else if (other.tag.Contains("White")) {
            CountWhite += 1;
            CounterWhite.text = "White : " + CountWhite;
        }
    }
}
