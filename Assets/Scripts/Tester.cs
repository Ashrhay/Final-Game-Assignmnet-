using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FlippingCard1 : MonoBehaviour
{
    [SerializeField]
    public  GameObject cardBack;

    public  bool cardBackIsActive = false;

    public void StartFlip()
    {
        StartCoroutine(FlipCard());
    }

       IEnumerator FlipCard()
    {
        for (int i = 0; i < 180; i++)
        {
            yield return new WaitForSeconds(0.01f);
            transform.Rotate(new Vector3(0, 1, 0));
        }

        cardBackIsActive = !cardBackIsActive;
        cardBack.SetActive(cardBackIsActive);
    }
}
