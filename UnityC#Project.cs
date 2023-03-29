using System.Collections;
using System.Collections.Generic;
using unityEngine;
using unityEngine.UI;

public class LogicProgram : MonoBehaviour
{

    public Text txtName;
    public Text txtScore;
    public Text txdHealth;

    public string playerName;
    public int point;
    public float hp;

    void start()
    {

        txtName.text = playerName;
        txtScore.text = "Score: " + point;
        txtHealth.text = "Health: " + hp;

    }

    void update()
    {

    }
}
