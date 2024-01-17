using UnityEngine;
using UnityEngine.UI;

public class SliderColorChanger : MonoBehaviour
{
    public Slider slider;          
    public Image fillImage;        

    public Color minColor = Color.red;   
    public Color maxColor = Color.green;  

    void Start()
    {
        
        UpdateSliderColor();
    }

    void Update()
    {
    
        UpdateSliderColor();
    }

    void UpdateSliderColor()
    {
       
        float normalizedValue = Mathf.InverseLerp(slider.minValue, slider.maxValue, slider.value);

       
        Color lerpedColor = Color.Lerp(minColor, maxColor, normalizedValue);

        
        fillImage.color = lerpedColor;
    }
}
