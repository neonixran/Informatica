matriz1 = [] # Nums 1
matriz2 = [] # Nums 2
resultado = [] # Resultados

longitud, sub_longitud = input("Ingrese el tamaño de la matriz (ej. 3x3): ").split("x")

print("Ingresa los números para la matriz nº1")
for fila in range(int(longitud)):
    matriz1.append([])
    print(len(matriz1))
    for columna in range(int(sub_longitud)):
        dato = int(input(f"Ingrese número {fila+1}.{columna+1}: "))
        matriz1[fila].append(dato)

print("\nIngresa los números para la matriz nº2")
for fila in range(int(longitud)):
    matriz2.append([])
    for columna in range(int(sub_longitud)):
        dato = int(input(f"Ingrese número {fila+1}.{columna+1}: "))
        matriz2[fila].append(dato)

print("\nLos resultados son")
for fila in range(int(longitud)):
    resultado.append([])
    for columna in range(int(sub_longitud)):
        suma = matriz1[fila][columna] + matriz2[fila][columna]
        resultado[fila].append(suma)

print(resultado)