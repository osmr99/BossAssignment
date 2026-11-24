using UnityEngine;

public class SwordVolumeScript : MonoBehaviour
{
    public GameObject swordVolume;
    [SerializeField] private bool isActive = false;

    private void Start()
    {
        swordVolume.SetActive(false);
    }
    public void ToggleVolume()
    {
        isActive = !isActive;
        swordVolume.SetActive(isActive ? true : false);
    }
}
