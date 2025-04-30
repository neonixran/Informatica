# Test 3 - Ejercicio 1 (30/04/2025)

# Programa que lea los lados de un triángulo y calcule y muestre en pantalla el área y perímetro de este.
'''print("Este programa calcula la área y el perímetro de un triángulo")
base = int(input("Ingrese la base: "))
altura = int(input("Ingrese la altura: "))

area = (base * altura) / 2
perimetro = base * 3 # base multiplicada por sus 3 lados

print(f"El área del triángulo es {area} cm² y su perímetro es {perimetro} cm")'''

# Manera correcta:
print("Este programa calcula la área y el perímetro de un triángulo")
l1 = int(input("Ingrese lado 1: "))
l2 = int(input("Ingrese lado 2: "))
l3 = int(input("Ingrese lado 3: "))
altura = int(input("Ingrese la altura: "))

area = (l3 * altura) / 2
perimetro = l1 + l2 + l3

print(f"El área del triángulo es {area} cm² y su perímetro es {perimetro} cm")
