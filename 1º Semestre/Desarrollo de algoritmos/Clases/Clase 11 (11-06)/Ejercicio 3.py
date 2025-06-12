# Imprimir las columas verticalmente
import random

matriz = []
longitud = 4

for f in range(longitud):
    matriz.append([])
    for c in range(longitud):
        matriz[f].append(random.randint(1, 50))

for c in range(len(matriz)):
    print(matriz[c])

print()
print(matriz)