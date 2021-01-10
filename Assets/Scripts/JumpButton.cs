using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpButton : MonoBehaviour
{
    public Button jumpButton;
    public Player player;

    void Start()
    {
        Button btn = jumpButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        player.Jump();
    }
}
