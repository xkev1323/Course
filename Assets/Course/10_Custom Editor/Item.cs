using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Course.CustomEditor
{
    public class Item : MonoBehaviour
    {
        public ItemSO data;
        [Space]
        public Image itemImg;
        public TextMeshProUGUI itemTitleTxt;
        public TextMeshProUGUI itemPriceTxt;

        private void Start()
        {
            Consume();
        }

        public void Consume()
        {
            itemImg.sprite = data.sprite;
            itemTitleTxt.text = data.title;
            itemPriceTxt.text = data.GetPrice();
        }
    }
}
