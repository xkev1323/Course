using UnityEngine;

namespace Course.FundamentosBasicos
{
    public class Variables : MonoBehaviour
    {
        // Variables
        // - Modificador de Acceso: public o private
        // - Tipo de Dato: int, float, bool, string
        // - Nombre
        // - Valor por Defecto (Opcional)

        // Tipos de Datos (Valor)
        public int myInt;
        public float myFloat;
        public double myDouble;
        public bool myBool;
        public char myChar;
        public Vector3 myStructVector;
        public Quaternion myStructQuaternion;

        // Tipos de Datos (Referencia)
        public Transform myClassTransform;
        public GameObject myClassGameObject;
        public Variables myClass;

        private void Start()
        {
            // Tipos de Datos (Valor)
            myInt = 5;
            myFloat = 2.5f;
            myDouble = 0.000000000001f;
            myBool = true;
            myChar = 'M';
            myStructVector = new Vector3(1, 2, 3);
            myStructQuaternion = new Quaternion(1, 2, 3, 4);

            // Tipos de Datos (Referencia)
            myClassTransform = this.transform;
            myClassGameObject = this.gameObject;
            myClass = this;
        }

    }
}
