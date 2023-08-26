using UnityEngine;

public class RealTimeGI : MonoBehaviour
{
    private void Update()
    {
        RenderSettings.ambientMode = AmbientMode.Trilight;
        RenderSettings.ambientSkyColor = Color.blue;
        RenderSettings.ambientEquatorColor = Color.green;
        RenderSettings.ambientGroundColor = Color.red;
    }
}
