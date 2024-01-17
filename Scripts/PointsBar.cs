using UnityEngine;
using UnityEngine.UI;

public class PointsBar : MonoBehaviour
{
    [Header("Sonlar")]
    public GameObject iyison;
    public GameObject ortaison;
    public GameObject ortasson;
    public GameObject kotuson;

    private bool durum = false;

    public int ilksinnir;
    public int ortaisinir;
    public int ortaksinir;
    public int kotusinir;

    public Slider pointsSlider;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bitis")
        {
            durum = !durum; 
        }
    }

    public void UpdatePoints(int points)
    {
        pointsSlider.value += points;

        if (!durum)
        {
            CheckAndActivateObjects();
        }
    }

    void CheckAndActivateObjects()
    {
        iyison.SetActive(pointsSlider.value > ilksinnir);

        ortaison.SetActive(ilksinnir < pointsSlider.value && pointsSlider.value > ortaisinir);

        ortasson.SetActive(ortaisinir < pointsSlider.value && pointsSlider.value > ortaksinir);

        kotuson.SetActive(ortaksinir < pointsSlider.value && pointsSlider.value > kotusinir);
    }
}


