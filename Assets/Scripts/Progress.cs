using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public Player Player;
    public Transform StartPlatform;
    public Transform FinishPlatform;
    public Slider Slider;
    private float t = 0;
    private void Update()
    {
        float startY = StartPlatform.transform.position.y;
        float endY = FinishPlatform.transform.position.y;
        float currrentY = Player.transform.position.y;
        if (t < Mathf.InverseLerp(startY, endY, currrentY))
        {
            t = Mathf.InverseLerp(startY, endY, currrentY);
            Slider.value = t;
        }
    }
}
