using UnityEngine;

public class GlowOnCollisionHandler : MonoBehaviour
{
    [SerializeField] private Material deafultMat;
    [SerializeField] private Material glowMat;

    private void OnCollisionEnter(Collision other) {
        GetComponent<Renderer>().material = glowMat;
    }
}
