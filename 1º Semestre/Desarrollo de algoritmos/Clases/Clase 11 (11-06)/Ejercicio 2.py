# Leer datos de una matriz cuadrada e imprimir la diagonal secundaria
matriz = []
longitud = 4

for f in range(longitud):
    matriz.append([])
    for c in range(longitud):
        dato = int(input(f"Ingrese un número {f + 1}.{c + 1}: "))
        matriz[f].append(dato)

print("La diagonal secundaria es: ")
c =  longitud - 1
for f in range(longitud):
    print(matriz[f][c]) # También se puede usar matriz[f][-f-1], quitando la variable "c" y su uso.
    c = c - 1