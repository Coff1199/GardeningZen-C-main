using UnityEngine;

public class FireFlicker : MonoBehaviour
{
    public Light fireLight;
    public float minIntensity = 0.8f;
    public float maxIntensity = 1.6f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireLight.intensity = Random.Range(minIntensity, maxIntensity);
    }
}
