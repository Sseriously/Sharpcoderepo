using UnityEngine;
using UnityEngine.UI;

public class LetsFindSomeUI : MonoBehaviour
{
	public Canvas myCanvas;

	public Text myText;

	public Text myOtherText;

	public Image myImage;

	void Start()
	{
		myCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();

		myText = GameObject.Find("Text").GetComponent<Text>();

		myOtherText = GameObject.Find("OtherText").GetComponent<Text>();

		myImage = GameObject.Find("Image").GetComponent<Image>();
		
	}

}
