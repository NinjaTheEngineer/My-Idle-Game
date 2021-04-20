using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    [SerializeField] private TMP_Text flaskText;
    public Data data;

    private void Start()
    {
        data = new Data();
    }

    private void Update()
    {
        flaskText.text = data.flasks + " Flasks";
    }

    public void GenerateFlasks()
    {
        data.flasks++;
    }
}
