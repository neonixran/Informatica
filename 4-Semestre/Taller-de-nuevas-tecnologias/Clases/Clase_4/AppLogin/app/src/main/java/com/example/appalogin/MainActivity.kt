package com.example.appalogin

import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        var usuario = findViewById<EditText>(R.id.txtUsuario)
        var contrasena = findViewById<EditText>(R.id.txtContrasena)
        var botonIngresar= findViewById<Button>(R.id.btnEntrar)

        botonIngresar.setOnClickListener {
            if (usuario.text.isEmpty() && contrasena.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar su usuario y contraseña", Toast.LENGTH_SHORT).show()
            } else if (usuario.text.isEmpty() && !contrasena.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar su usuario", Toast.LENGTH_SHORT).show()
            } else if (!usuario.text.isEmpty() && contrasena.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar su contraseña", Toast.LENGTH_SHORT).show()
            } else {
                
            }
        }
    }
}