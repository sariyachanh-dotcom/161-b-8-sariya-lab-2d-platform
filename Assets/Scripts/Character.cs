using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public float Health
    {  
        get { return health; } 
        set { health = (value < 0) ? 0 : value ; }  
    }
    public float MaxHealth
    {
        get { return maxHealth; }
        set { maxHealth = (value < 0) ? 0 : value; }
    }

    protected Animator anim ;
    protected Rigidbody2D rb;

    public Image healthBar;


    public void UpdateHealthBarUI()
    {
        float fillAmount = Mathf.Clamp01(Health / MaxHealth);
        healthBar.fillAmount = fillAmount;
    }

    public void Initialized(int startHealth)
    {
        Health = startHealth;
        MaxHealth = startHealth;
        Debug.Log($"{this.name} is Initialized with Health : {this.MaxHealth}");
        if (healthBar != null )
            UpdateHealthBarUI();

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage}, Current Health : {Health} / {MaxHealth}");
        if (healthBar != null)
            UpdateHealthBarUI();

        IsDead();
    }
    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else { return false; }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
