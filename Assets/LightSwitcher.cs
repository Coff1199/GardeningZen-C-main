using UnityEngine;

public class LightSwitcher : MonoBehaviour
{
    public Light directionalLight;
    public Color nightColor = new Color(0.05f, 0.05f, 0.2f);
    public float nightIntensity = 0.1f;
    public Color dayColor = Color.white;
    public float dayIntensity = 1f;

    public bool isNight = false;

    public void ToggleLight() 
    {
        if (isNight)
        {
            directionalLight.color = nightColor;
            directionalLight.intensity = nightIntensity;
        }
        else
        {
            directionalLight.color = dayColor;
            directionalLight.intensity = dayIntensity;
        }
        // turn this off for testing purposes
        isNight = !isNight;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	
	// turn this on for testing purposes
        //ToggleLight();
    }
}
