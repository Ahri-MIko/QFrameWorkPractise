using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int EnemyCount = 0;

    [SerializeField] private GameObject GamePassPanel;
    void OnMouseDown()
    {
        EnemyCount++;
        Destroy(gameObject);

        if(EnemyCount == 4)
        {
            GamePassPanel.SetActive(true);
        }
    }
}
