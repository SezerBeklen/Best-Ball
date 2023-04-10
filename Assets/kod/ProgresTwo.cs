using UnityEngine;
using UnityEngine.UI;

public class ProgresTwo : MonoBehaviour
{
    [Header("UI References :")]

    [SerializeField] private Image UI_FillÝmage;

    [Header("player And Endline References :")]

    [SerializeField] private Transform[] PlayerTransform;
    [SerializeField] private Transform EndlineTransform;

    private Vector3 EndlinePosition;
    private float fullDistance;
    public int indexProgres;

    private void Start()
    {
        indexProgres = PlayerPrefs.GetInt("SelectedBall", 0);
        EndlinePosition = EndlineTransform.position;
        fullDistance = GetDistance();
    }

    private float GetDistance()
    {
        return Vector3.Distance(PlayerTransform[indexProgres].position, EndlinePosition);
    }

    private void UpdatePrograssiveFill(float value)
    {
        UI_FillÝmage.fillAmount = value;
    }


    void Update()
    {
        if (PlayerTransform[indexProgres].position.z >= EndlinePosition.z)
        {
            float newDistance = GetDistance();
            float ProgressValue = Mathf.InverseLerp(fullDistance, 0f, newDistance);
            UpdatePrograssiveFill(ProgressValue);
        }


    }
}
