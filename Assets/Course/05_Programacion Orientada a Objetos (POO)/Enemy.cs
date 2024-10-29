using UnityEngine;

namespace Course.POO
{
    public abstract class Enemy : MonoBehaviour
    {
        [Header("Enemy")]
        [SerializeField] protected string _title;
        [SerializeField] protected int damage;
        [SerializeField] protected float health;

        //public string Title { get => _title; set => _title = value; }

        public string Title
        {
            get
            {
                //Debug.Log("Title GET");
                return _title;
            }
            //set
            //{
            //    Debug.Log("Title SET");
            //    _title = value;
            //}
        }

        private void Start()
        {
            //Attack();

            // Get
            //string temp = Title;

            // Set
            //Title = "Pepe";
        }

        public virtual void Attack()
        {
            Debug.Log($"Enemy '{_title}' ATTACK. Damage: '{damage}'");
        }

        public abstract void Defense();

    }
}
