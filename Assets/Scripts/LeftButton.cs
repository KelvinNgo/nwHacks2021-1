using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftButton : MonoBehaviour
{
    public Button leftButton;
    public Player player;

    void Start()
    {
        Button btn = leftButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        float move = -6;
        player.Move(move);
    }
}
