using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    public Transform elevatorTransform;
    public float waitTime = 10f;
    public Animator anim;
    private int currentFloor;

    public Transform basementTransform;
    public Transform fifthTransform;
    public Transform twelfthTransform;
    public Transform twentiethTransform;

    public AudioSource audioSource;
    public AudioClip startElevatorClip;
    public AudioClip openElevatorClip;

    // Start is called before the first frame update

    private void Start()
    {
        currentFloor = 0;
    }
    public void GoToBasement()
    {
        if(currentFloor == 0)
        {
            return;
        }
        StartElevatorSound();
        StartCoroutine(MoveToBasement(waitTime));
    }
    public void GoToFifthFloor()
    {
        if (currentFloor == 5)
        {
            return;
        }
        StartElevatorSound();
        StartCoroutine(MoveToFifthFloor(waitTime));
    }
    public void GoToTwelfthFloor()
    {
        if (currentFloor == 12)
        {
            return;
        }
        StartElevatorSound();
        StartCoroutine(MoveToTwelfthFloor(waitTime));
    }
    public void GoToTwentiethFloor()
    {
        if (currentFloor == 20)
        {
            return;
        }
        StartElevatorSound();
        StartCoroutine(MoveToTwentiethFloor(waitTime));
    }
    private IEnumerator MoveToBasement(float time)
    {
        CloseElevator();
        yield return new WaitForSeconds(time);
        elevatorTransform.position = basementTransform.position;
        OpenElevator();
        currentFloor = 0;
    }
    private IEnumerator MoveToFifthFloor(float time)
    {
        CloseElevator();
        yield return new WaitForSeconds(time);
        elevatorTransform.position = fifthTransform.position;
        OpenElevator();
        currentFloor = 5;
    }
    private IEnumerator MoveToTwelfthFloor(float time)
    {
        CloseElevator();
        yield return new WaitForSeconds(time);
        elevatorTransform.position = twelfthTransform.position;
        OpenElevator();
        currentFloor = 12;
    }
    private IEnumerator MoveToTwentiethFloor(float time)
    {
        CloseElevator();
        yield return new WaitForSeconds(time);
        elevatorTransform.position = twentiethTransform.position;
        OpenElevator();
        currentFloor = 20;
    }
    public void OpenElevator()
    {
        anim.SetBool("IsOpening", true);
        StopElevatorSound();
    }
    public void CloseElevator()
    {
        anim.SetBool("IsOpening", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            CloseElevator();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            OpenElevator();
        }
    }
    void StartElevatorSound()
    {
        audioSource.loop = true;
        audioSource.clip = startElevatorClip;
        audioSource.Play();
    }
    void StopElevatorSound()
    {
        audioSource.loop = false;
        audioSource.clip = openElevatorClip;
        audioSource.Play();
    }
}
