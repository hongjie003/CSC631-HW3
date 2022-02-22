using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Material[] altColors;
    private int index;

    public void nextColor() {
        index = (index + 1) % altColors.Length; // keep index between 0 to length

        GetComponent<Renderer>().material = altColors[index];
    }
}
