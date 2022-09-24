using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    eatACornDog eACD;
    [SerializeField] GameObject canvas;
    public int scoreF;
    public Text scoreText;
    


    void Awake()
    {

        eACD = canvas.GetComponent<eatACornDog>();

    }
  

    // Update is called once per frame
    void Update()
    {

        scoreF = eACD.corndogsEaten; //reference to the corndogs eaten variable in the eACD script
        scoreText.text = eACD.corndogsEaten.ToString();
       

    }
}
