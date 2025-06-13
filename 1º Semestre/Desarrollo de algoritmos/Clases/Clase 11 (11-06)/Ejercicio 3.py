# Imprimir las columas verticalmente
import random

matriz = []
longitud = 2

for f in range(longitud):
    matriz.append([])
    for c in range(longitud):
        dato = int(input(f"Ingrese un número {f}.{c}: "))
        matriz[f].append(dato)

for c in range(len(matriz)):
    print(matriz[c])

print()
print(matriz)