using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public int MinPlatforms;
    public float Distance;
    public Transform FinishPlatform;
    public Transform StartPlatform;
    public Transform Cylinder;

    private void Awake()
    {
        StartPlatform.localPosition = new Vector3(0, 0, 0);
        int platformsCount = MinPlatforms;
        for (int i = 0; i < platformsCount; i++)
        {
            int prefabIndex = Random.Range(0, PlatformPrefabs.Length);
            GameObject platform = Instantiate(PlatformPrefabs[prefabIndex], transform);
            platform.transform.localPosition = new Vector3(0, -Distance * (i + 1), 0);
            platform.transform.localRotation = Quaternion.Euler(0, Random.Range(0, 360f), 0); ;
        }
        FinishPlatform.localPosition = new Vector3(0, -Distance * (platformsCount + 1), 0);
        Cylinder.localScale = new Vector3(1, (platformsCount + 2) * Distance/2, 1);
    }
}
