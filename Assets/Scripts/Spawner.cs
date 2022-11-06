using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform spawnObject;
    static public float distance = 5;
    static public float speedObject = 2;
    private float delayRespawn = 0.5f;
    private float timer = 0;

    private void Update()
    {
        if ( timer <= 0)
        {
            Spawn();
            timer = delayRespawn;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    private void Spawn()
    {
        var newObject = Instantiate(spawnObject,transform);
        newObject.rotation = Random.rotation;
    }

    public Text SpeedText;
    public void EnterSpeed()
    {
        speedObject = float.Parse(SpeedText.text);
    }

    public Text DistanceText;
    public void EnterDistance()
    {
        distance = float.Parse(DistanceText.text);
    }

    public Text TimeText;
    public void EnterDelay()
    {
        delayRespawn = float.Parse(TimeText.text);
    }
}
