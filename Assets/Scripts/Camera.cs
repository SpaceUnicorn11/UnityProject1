using UnityEngine;

public class Camera : MonoBehaviour
{
    public Player Player;
    public Vector3 Offset;
    public float Speed;

    void Update()
    {
        if (Player.CurrentPlatform == null) return;

        Vector3 targetPosition = Player.CurrentPlatform.transform.position + Offset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
    }
}
