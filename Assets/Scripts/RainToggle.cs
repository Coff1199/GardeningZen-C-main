using UnityEngine;

public class RainToggle : MonoBehaviour
{
    public GameObject rain;
    public AudioSource rainSounds;

    public bool isRaining = false;

    public void ToggleRain() 
    {
        if (rain == null) return;

        isRaining = !isRaining;
        rain.SetActive(isRaining);
        if (isRaining) 
        {
            if (!rainSounds.isPlaying) {
                rainSounds.Play();
                rainSounds.loop = true;
            }
        } else {
            if (rainSounds.isPlaying) {
                rainSounds.Stop();
            }
        }
    }
 
    #if UNITY_EDITOR
        private void OnValidate()
        {
            rain.SetActive(isRaining);
            if (isRaining) 
            {
                if (!rainSounds.isPlaying) {
                    rainSounds.Play();
                    rainSounds.loop = true;
                }
            } else {
                if (rainSounds.isPlaying) {
                    rainSounds.Stop();
                }
            }
        }
    #endif

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
