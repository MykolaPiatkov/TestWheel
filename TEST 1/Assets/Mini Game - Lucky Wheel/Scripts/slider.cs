using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class slider : MonoBehaviour
{
    public Slider slider1;
    public TextMeshProUGUI sliderText;
    
    // Start is called before the first frame update
    void Start()
    {
        sliderText.text = slider1.value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        sliderText.text = slider1.value.ToString();
    }
    
}
