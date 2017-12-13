using UnityEngine;
using System.Collections;

public class DemoController : MonoBehaviour
{

    public Animator m_animator;

    void Awake()
    {

    }

    void Start()
    {

    }


    void Update()
    {
  
    }


    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 80, 15), "Idle"))
        {
            m_animator.SetTrigger("Idle");
            m_animator.SetBool("Move", false);
        }

        if (GUI.Button(new Rect(10, 30, 80, 15), "Attack1"))
        {
            m_animator.SetTrigger("Attack1");
        }

        if (GUI.Button(new Rect(10, 50, 80, 15), "Attack2"))
        {
            m_animator.SetTrigger("Attack2");
        }

        if (GUI.Button(new Rect(10, 70, 80, 15), "Attack3"))
        {
            m_animator.SetTrigger("Attack3");
        }

        if (GUI.Button(new Rect(10, 90, 80, 15), "Emotion"))
        {
            m_animator.SetTrigger("Emotion");
        }

        if (GUI.Button(new Rect(10, 110, 80, 15), "Rest1"))
        {
            m_animator.SetTrigger("Rest1");
        }

        if (GUI.Button(new Rect(10, 130, 80, 15), "Rest2"))
        {
            m_animator.SetTrigger("Rest2");
        }

        if (GUI.Button(new Rect(10, 150, 80, 15), "Die"))
        {
            m_animator.SetTrigger("Die");
        }

        if (GUI.Button(new Rect(10, 170, 80, 15), "HurtBack"))
        {
            m_animator.SetTrigger("HurtBack");
        }

        if (GUI.Button(new Rect(10, 190, 80, 15), "HurtFront"))
        {
            m_animator.SetTrigger("HurtFront");
        }

        if (GUI.Button(new Rect(10, 210, 80, 15), "Move"))
        {
            m_animator.SetBool("Move", true);
            m_animator.SetTrigger("Run");
        }

        if (GUI.Button(new Rect(10, 230, 80, 15), "Strike1"))
        {
            m_animator.SetTrigger("Strike1");
        }

        if (GUI.Button(new Rect(10, 250, 80, 15), "Strike2"))
        {
            m_animator.SetTrigger("Strike2");
        }

        if (GUI.Button(new Rect(10, 270, 80, 15), "Standup"))
        {
            m_animator.SetTrigger("Standup");
        }

        GUI.Label(new Rect((Screen.width / 2) - 50, Screen.height - 30, 500, 20), "SHIBAPOWER PERSENTED");
    }
}
