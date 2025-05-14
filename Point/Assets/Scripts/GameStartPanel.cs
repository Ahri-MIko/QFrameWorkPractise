using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartPanel : MonoBehaviour
{
 
    [SerializeField]private Button BtnGameStart;
    [SerializeField]private GameObject Enemies;

    void Start()
    {
        BtnGameStart.onClick.AddListener(()=>{
            gameObject.SetActive(false);
            Enemies.SetActive(true);

        });
    }
}
