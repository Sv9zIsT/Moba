using FishNet.Transporting.Bayou;
using FishNet.Transporting.Multipass;
using FishNet.Transporting.Tugboat;
using UnityEngine;

public class Startup : MonoBehaviour
{
    void Start()
    {
        Multipass multipass = GetComponent<Multipass>();

#if UNITY_WEBGL && !UNITY_EDITOR
        multipass.SetClientTransport<Bayou>();
#else
        multipass.SetClientTransport<Tugboat>();
#endif
    }
}
