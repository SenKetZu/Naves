using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    public Transform pj;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pj.position + offset;
    }
}
