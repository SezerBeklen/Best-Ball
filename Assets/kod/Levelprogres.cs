using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levelprogres : MonoBehaviour
{
    /* [SerializeField] GameObject Player;
     [SerializeField] GameObject Finish;

     Image Progressbar;
     float maxDistance;
     void Start()
     {
         Progressbar = GetComponent<Image>();
         maxDistance = Finish.transform.position.z;
         Progressbar.fillAmount = Player.transform.position.z / maxDistance;
     }


     void Update()
     {
         if (Progressbar.fillAmount <= 1)
         {
             Progressbar.fillAmount = Player.transform.position.z / maxDistance;
         }


     }*/
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
        if (PlayerTransform[indexProgres].position.z <= EndlinePosition.z)
        {
            float newDistance = GetDistance();
            float ProgressValue = Mathf.InverseLerp(fullDistance, 0f, newDistance);
            UpdatePrograssiveFill(ProgressValue);
        }
        

    }


}





