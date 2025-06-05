'''
Hacer un programa que dado 1 arreglo con los números del 1 al 10 genere las tablas de
multiplicar y las imprima como tabla con sus resultados.
'''

A = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

for i in A:
    print(f"\nTabla del {i}:")
    for j in range(1, 11):
        print(f"{i} * {j} = {i * j}")