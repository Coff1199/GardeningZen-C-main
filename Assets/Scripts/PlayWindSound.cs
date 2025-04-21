using UnityEngine;

public class PlayWindSound : MonoBehaviour
{
    public AudioSource wind;
    public bool isActive = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void ToggleWind() 
    {
        if (isActive)
        {
            if (!wind.isPlaying) 
            {
                wind.Play();
                wind.loop = true;
            }
        } else 
        {
            if (wind.isPlaying) 
            {
                wind.Stop();
            }
        }
    }

    #if UNITY_EDITOR
        private void OnValidate()
        {
            if (isActive)
            {
                if (!wind.isPlaying) 
                {
                    wind.Play();
                    wind.loop = true;
                }
            } else 
            {
                if (wind.isPlaying) 
                {
                    wind.Stop();
                }
            }
        }
    #endif

    // Update is called once per frame
    void Update()
    {
        
    }
}
