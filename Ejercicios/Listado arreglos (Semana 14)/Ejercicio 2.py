'''
Hacer un programa que lea 10 números, los guarde en un arreglo, busque el menor y el mayor
de los elementos y los imprima
'''

longitud = 10
A = []

for i in range(longitud):
    dato = int(input(f"Ingrese el número nº{i+1}: "))
    A.append(dato)

menor = min(A)
mayor = max(A)

print(f"El menor de los elementos es {menor} y el mayor es {mayor}")