using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.UI;
public class FishButton : MonoBehaviour
{
    public bool yep = false;
    public GameObject hook;
    public Animator animator;
    public float timer = 0;

    public TextMeshProUGUI baitText;

    public HookBaitCount baitDecrease;

    public AudioSource audio;

    private void Start()
    {
        animator = hook.GetComponent<Animator>();
        baitDecrease = hook.GetComponent<HookBaitCount>();
    }
    void Update()
    {
        if (yep)
        {
            baitDecrease.decreaseBait = true;
            timer += Time.deltaTime;
            animator.SetBool("yep", true);
            
            yep = false;
            
        }
        else
        {
            timer = 0;
            animator.SetBool("yep", false);
        }
    }
    public void releasehook()
    {
        audio.Play();
        yep = true;
    }
}
