import os

matriz1 = [] # Nums 1
matriz2 = [] # Nums 2
sumas = [] # Resultados de la suma

while True:
    try:
        longitud_filas, longitud_columnas = input("Ingrese el tamaño de la matriz (ej. 3x3): ").split("x")
        
        if longitud_filas == "" or longitud_columnas == "": # Valida si las dimensiones están vacias
            print("\t[!] Debe ingresar un número para el tamaño")
            continue
        elif int(longitud_filas) <= 0 or int(longitud_columnas) <= 0: # Valida si las dimensiones son menores o igual a cero
            print("\t[!] Debe ingresar números positivos.")
            continue
        break
    except ValueError: # Valida si el separador es válido
        print("\t[!] El separador que está usando es incorrecto, debe usar x (ej. 3x3)")
        continue

# Lectura y calculo de las matrices
os.system("cls")
print("Ingresa los números para la matriz nº1")
for fila in range(int(longitud_filas)):
    matriz1.append([])
    for columna in range(int(longitud_columnas)):
        while True:
            try:
                dato = int(input(f"Ingrese número {fila+1}.{columna+1}: "))
                matriz1[fila].append(dato)
                break
            except ValueError:
                print("\t[!] Ingrese sólo números enteros.")
                continue

print("\nIngresa los números para la matriz nº2")
for fila in range(int(longitud_filas)):
    matriz2.append([])
    for columna in range(int(longitud_columnas)):
        while True:
            try:
                dato = int(input(f"Ingrese número {fila+1}.{columna+1}: "))
                matriz2[fila].append(dato)
                break
            except ValueError:
                print("\t[!] Ingrese sólo números enteros.")
                continue

print("\nLos resultados son")
for fila in range(int(longitud_filas)):
    sumas.append([])
    for columna in range(int(longitud_columnas)):
        suma = matriz1[fila][columna] + matriz2[fila][columna]
        sumas[fila].append(suma)

print(sumas)