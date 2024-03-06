using UnityEngine;

public class flashLight : MonoBehaviour
{
  public  float onTime = 0;
    float startTime = 0;
    float defaultTime = 30;
    bool wasoff = true;
    public void func()
    {
        Light light = GetComponent<Light>();
        if (light.enabled)
        {

            light.enabled = false;
        }
        else
        {
            if(onTime + 1 < defaultTime)
            light.enabled = true;
        }

        Debug.Log($"im here");

    }
    private void Update()
    {
            if (GetComponent<Light>().enabled && wasoff)
            {
                startTime = Time.time;
                wasoff = false;

            }
            else if (!GetComponent<Light>().enabled && !wasoff)
            {
                onTime += Time.time - startTime;
                wasoff = true;

            }
        if ((Time.time - startTime) + onTime > defaultTime && GetComponent<Light>().enabled &&  onTime < defaultTime)
        {
            GetComponent<Light>().enabled = false;
            wasoff = true;
            Debug.Log(Time.time - startTime);
            Debug.Log("i reset it :)");
            onTime = defaultTime +2;


        }
     

    }

}
