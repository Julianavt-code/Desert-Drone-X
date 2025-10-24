using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class scripts : MonoBehaviour

{
    public float speed = 5f;
    public int gemamorada = 0;
     public int gemaverde = 0;
    public bool touchremolino = false;
    public bool touchcofre = false;
    public TextMeshProUGUI textGemaMorada;
    public TextMeshProUGUI textGemaVerde;
    public TextMeshProUGUI textCofre;
    public TextMeshProUGUI textNotifications;
    public int cofre = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateTextgemamorada();
        UpdateTextgemaverde();
        UpdateTextcofre();
        UpdateTextNotifications("Recolecta las gemas perdidas");
    }

    // Update is called once per frame
    void Update()
    {

        // vamos a leer las teclas wasd o las flechas del teclado
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //creamos un vector para almacenar la direccion del movimiento
        Vector3 direction = new Vector3(moveHorizontal, moveVertical, 0);

        transform.Translate(direction * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.CompareTag("gemamorada"))
        {
            gemamorada = gemamorada + 1;
            UpdateTextgemamorada();

            Destroy(other.gameObject);
            UpdateTextNotifications("�Recolectaste una gema!");
            Debug.Log("collected!!!");
            Debug.Log("gemamorada: " + gemamorada);

        }
         if (other.CompareTag("gemaverde"))
        {
            gemaverde = gemaverde + 1;
            UpdateTextgemaverde();

            Destroy(other.gameObject);
            UpdateTextNotifications("�Recolectaste una gema!");
            Debug.Log("collected!!!");
            Debug.Log("gemaverde: " + gemaverde);

        }
        if (other.CompareTag("remolino"))
        {
       
            touchremolino = true;
            UpdateTextNotifications("Has tocado el remolino, perdiste :(");
            Debug.Log("has tocado el remolino, perdiste");
            Destroy(gameObject);
        }

        if (other.CompareTag("cofre"))
        {
            cofre = cofre + 1;
            UpdateTextcofre();
            touchcofre = true;
            Destroy(other.gameObject);
            UpdateTextNotifications("�Recolectaste el cofre dorado!");
            Debug.Log("has recolectado el cofre dorado, bien hecho");
           

        }
       


        //condicion de victoria
        if (gemamorada >= 6 && gemaverde>= 4 && !touchremolino && touchcofre) // es un booleana asumimos que haskey es true y poner ! antes de una variable es false
        {
            UpdateTextNotifications("��Ganaste la partida!!");
            Debug.Log("ganaste");
        }


    }

    void UpdateTextgemamorada()
    {
        textGemaMorada.text = "gemamorada: " + gemamorada + "/6";
    }
    void UpdateTextgemaverde()
    {
        textGemaVerde.text = "gemaverde: " + gemaverde + "/4";
    }

    void UpdateTextcofre()
    {
        textCofre.text = "cofre dorado: " + cofre + "/1";
    }
    
    void UpdateTextNotifications(string message)
    {
        textNotifications.text =  message;
    }

}