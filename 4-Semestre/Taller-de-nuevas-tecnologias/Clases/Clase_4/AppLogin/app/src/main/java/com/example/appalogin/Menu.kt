package com.example.appalogin

<<<<<<< HEAD
import android.os.Bundle
=======
import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.TextView
>>>>>>> de5fe6a (sadas)
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class Menu : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_menu)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
<<<<<<< HEAD
=======

        var usuarios = findViewById<Button>(R.id.btnUsuarios);
        var ejercicio1 = findViewById<Button>(R.id.btnEjercicio1);
        var ejercicio2 = findViewById<Button>(R.id.btnEjercicio2);
        var salir = findViewById<Button>(R.id.btnSalir)

        usuarios.setOnClickListener {
            startActivity(Intent(this, usuarios::class.java));
            finish();
        }

        ejercicio1.setOnClickListener {
            startActivity(Intent(this, Ejercicio1::class.java));
            finish();
        }

        ejercicio2.setOnClickListener {
            startActivity(Intent(this, Ejercicio2::class.java));
            finish();
        }

        salir.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java));
            finish();
        }
>>>>>>> de5fe6a (sadas)
    }
}