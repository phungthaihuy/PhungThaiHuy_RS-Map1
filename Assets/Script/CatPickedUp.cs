using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPickedUp : MonoBehaviour
{
    [SerializeField] private Player player;
    public void SetCatParent(Player player)
    {
        transform.parent = player.GetCatFollower1();
        Debug.Log(player.GetCatFollower1().transform.position);
        transform.localPosition = Vector3.zero;
    }
}
