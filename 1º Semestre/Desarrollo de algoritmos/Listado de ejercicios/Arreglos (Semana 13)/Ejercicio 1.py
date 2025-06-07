'''
Hacer un programa que lea 10 elementos, los guarde en un arreglo, luego duplique los
elementos del arreglo (que queden guardados) e imprima los elementos duplicados
'''

longitud = 2
A = []

for i in range(longitud): # El usuario ingresa la cantidad de números definidos por la variable longitud
    dato = int(input(f"Ingrese el elemento 1.{i+1}: ")) # Variable de paso para ingresar los números
    A.append(dato)

for i in range(longitud):
    A[i] *= 2

print(f"Duplicada: {", ".join([str(A[i]) for i in range(longitud)])}") # Imprime el mismo arreglo pero ahora con los números duplicados