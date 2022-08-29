using UnityEngine;
using UnityEngine.UI;

namespace ForestView.UI
{
    public class FillValueNumber : MonoBehaviour
    {
        public Image TargetImage;

        private void Update()
        {
            float amount = TargetImage.fillAmount * 100;
            gameObject.GetComponent<Text>().text = amount.ToString("F0");
        }
    }
}
