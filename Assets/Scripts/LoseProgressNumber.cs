using UnityEngine;
using UnityEngine.UI;

public class LoseProgressNumber : MonoBehaviour
{
    public Slider Slider;
    public Text Text;

    private void Awake()
    {
        Text.text = (Slider.value * 100).ToString();
    }
}
