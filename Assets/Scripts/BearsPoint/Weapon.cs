using UnityEngine;

namespace DefaultNamespace
{
	public class Weapon : MonoBehaviour
	{
		[SerializeField] private Bullet _bullet;
		[SerializeField] private Transform _shootPosition;
	    private void Update()
	    {
	        if(Input.GetKeyDown(KeyCode.Space))
		        Shoot();
	    }
	    
	    private void Shoot()
	    {
		    Bullet bullet = Instantiate(_bullet, _shootPosition.position, Quaternion.identity);
		    bullet.Move(transform.forward);
	    }
	}
}