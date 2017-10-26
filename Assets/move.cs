using UnityEngine;

public class move : MonoBehaviour {
    
    private const float Y_ANGLE_MIN = -0.0f;
    private const float Y_ANGLE_MAX = 0.0f;

    public Rigidbody cube;
    public float force = 200;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
	public GameObject boss;
	public bool combo1 = false;
	public bool combo2 = false;
	public bool combo3 = false;

    private void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            cube.AddRelativeForce(force, 0, 0);
           
        }
        if (Input.GetKey("w"))
        {
            cube.AddRelativeForce(0, 0, force);
            
        }
        if (Input.GetKey("a"))
        {
            cube.AddRelativeForce(-force, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            cube.AddRelativeForce(0, 0, -force);
        }
    }

    private void Update()
    {
		checkforcombo ();
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");
        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);

    }

    private void LateUpdate()
    {
        Quaternion rotation = Quaternion.Euler(currentY*20, currentX*20, 0);
        transform.rotation = rotation;

    }

	void dodamage(int dmg){
		boss.GetComponent<FireNotes> ().health = boss.GetComponent<FireNotes> ().health - dmg;
	}

	void checkforcombo(){
		if(Input.GetKeyDown("z") || combo1){
			combo1 = true;
			if (Input.GetKeyDown("x") || combo2) {
				combo2 = true;
				if (Input.GetKey ("c")) {
					combo3 = true;
					if (combo3) {
						dodamage (10);
						combo1 = false;
						combo2 = false;
						combo3 = false;
					}
				} else if(Input.anyKeyDown && !Input.GetKeyDown("x")){
					combo2 = false;
					combo1 = false;
				}
			} else if(Input.anyKeyDown && !Input.GetKeyDown("z")){
				combo1 = false;
			}
		}
	}

}
