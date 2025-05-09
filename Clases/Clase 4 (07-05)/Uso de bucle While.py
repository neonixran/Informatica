n = float(input("Ingrese un número positivo: "))

while n < 0:
    print("Ingrese número positivo")
    n = float(input("Ingrese un número positivo"))

print(f"El número ingresado es {n}")