using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject platform;

    private float initialRotationValue = 0;
    private EnumIllusionStates states = EnumIllusionStates.Idle;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        switch (states)
        {
            case EnumIllusionStates.Idle:
                Idle();
                break;
            case EnumIllusionStates.Rotate:
                Rotate();
                break;
            case EnumIllusionStates.End:
                End();
                break;
        }
    }

    public void Idle()
    {
        initialRotationValue = platform.transform.rotation.z;
    }

    public void Rotate()
    {
        platform.transform.Rotate(0, 0, 20f * Time.deltaTime);

        if(platform.transform.eulerAngles.z >= initialRotationValue + 90f)
            states = EnumIllusionStates.End;
        //Debug.Log("Initial value " + initialRotationValue + " actual value " + platform.transform.eulerAngles.z);
    }

    public void End()
    {
        states = EnumIllusionStates.Idle;
    }

    public void ButtonPress()
    {
        states = EnumIllusionStates.Rotate;
        Debug.Log("Button pressed!");
    }
}
