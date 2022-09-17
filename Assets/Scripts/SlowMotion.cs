using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    public float slowDownFactor = 0.05f;
    public float slowDownLength = 2f;

    // Uncomment for using as Singleton
    // public static SlowMotion instance; 

    // Uncomment for using as Singleton
    // private void Awake()
    // {
    //     if (!instance) instance = this;
    // }

    private void Update()
    {
        Time.timeScale += (1f / slowDownLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    public void DoSlowMotion()
    {
        Time.timeScale = slowDownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }

}
