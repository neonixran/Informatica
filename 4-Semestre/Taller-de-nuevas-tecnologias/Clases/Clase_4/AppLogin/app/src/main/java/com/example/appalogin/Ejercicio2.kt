package com.example.appalogin

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Switch
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import org.w3c.dom.Text

class Ejercicio2 : AppCompatActivity() {
    private lateinit var num1: EditText
    private lateinit var num2: EditText
    private lateinit var resultado: TextView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio2)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        var menu = findViewById<Button>(R.id.btnEj2Menu);

        num1 = findViewById(R.id.txtEj2Num1)
        num2 = findViewById(R.id.txtEj2Num2)
        resultado = findViewById(R.id.lblEj2Resultado)

        var suma = findViewById<Button>(R.id.btnEj2Suma)
        var resta = findViewById<Button>(R.id.btnEj2Resta)
        var multiplicacion = findViewById<Button>(R.id.btnEj2Multiplicacion)
        var division = findViewById<Button>(R.id.btnEj2Division)

        menu.setOnClickListener {
            startActivity(Intent(this, Menu::class.java))
            finish()
        }

        suma.setOnClickListener {
            operacion("+")
        }

        resta.setOnClickListener {
            operacion("-")
        }

        multiplicacion.setOnClickListener {
            operacion("*")
        }

        division.setOnClickListener {
            operacion("/")
        }
    }

    fun operacion(op: String) {
        when(op) {
            "+" -> {
                 resultado.text = (num1.text.toString().toInt() + num2.text.toString().toInt()).toString()
            }
            "-" -> {
                resultado.text = (num1.text.toString().toInt() - num2.text.toString().toInt()).toString()
            }
            "*" -> {
                resultado.text = (num1.text.toString().toInt() * num2.text.toString().toInt()).toString()
            }
            "/" -> {
                resultado.text = (num1.text.toString().toInt() / num2.text.toString().toInt()).toString()
            }
        }
    }
}