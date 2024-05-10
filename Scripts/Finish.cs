using UnityEngine;

public class Finish : MonoBehaviour
{

    public GameManager Manager;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Manager.finish();
        }
    }
}
