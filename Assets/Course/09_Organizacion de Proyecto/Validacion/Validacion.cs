using UnityEngine;

namespace Course.OrganizacionProyecto
{
    public class Validacion : MonoBehaviour
    {
        [SerializeField] private Sprite sprite;
        [SerializeField] private SpriteRenderer spriteRenderer;

        private void OnValidate() //Funciona cuando haces cambios en el editor en el script, y se ejecuta lo que tiene el metodo
        {
            if (!spriteRenderer)
            {
                spriteRenderer = GetComponent<SpriteRenderer>();
            }

            if (!sprite)
            {
                Debug.Log("Missing Sprite!");
                return;
            }

            spriteRenderer.sprite = sprite;
        }
    }
}
