using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int bumps = 0;

    private void OnCollisionEnter(Collision Other)
    {
        bumps++;
        Debug.Log("Number of Bumps: " + bumps);
    }
}
