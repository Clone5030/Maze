using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeSpeed : MonoBehaviour
{
    static Slider speedSlider = GameObject.Find("SpeedSlide").GetComponent<Slider>();
    static Slider sensSlider = GameObject.Find("SensSlide").GetComponent<Slider>();
    float speedVal;
    float sensVal;
    static TMP_Text speedText = GameObject.Find("SpeedText").GetComponent<TMP_Text>();
    static TMP_Text sensText = GameObject.Find("SensText").GetComponent<TMP_Text>();

    void Start()
    {
        speedSlider.onValueChanged.AddListener((v) =>
        {
            speedText.text = v.ToString("0.00");
        });
        sensSlider.onValueChanged.AddListener((v) =>
        {
            sensText.text = v.ToString("0.00");
        });
    }

    void Update()
    {
    }
}
