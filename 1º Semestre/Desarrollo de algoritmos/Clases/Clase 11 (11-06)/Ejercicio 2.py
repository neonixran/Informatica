# Leer datos de una matriz cuadrada e imprimir la diagonal secundaria
matriz = []
longitud = 2

for f in range(longitud):
    matriz.append([])
    for c in range(longitud):
        dato = int(input(f"Ingrese un número [{f}][{c}]: "))
        matriz[f].append(dato)


print("La diagonal secundaria es: ")
c =  longitud-1
for f in range(longitud):
    print(matriz[f][c])
    c = c - 1