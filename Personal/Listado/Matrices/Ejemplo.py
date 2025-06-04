# Imprime los números de la matriz
matriz = [
    [1, 2],
    [3, 4],
    [5, 6]
]

for fila in range(len(matriz)):
    for columna in range(len(matriz[fila])):
        print(f"Elemento en posición ({fila}, {columna}): {matriz[fila][columna]}")