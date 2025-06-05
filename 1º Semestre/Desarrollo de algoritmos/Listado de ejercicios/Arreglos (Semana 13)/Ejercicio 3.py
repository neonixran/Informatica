'''
Hacer un programa que genere los 15 múltiplos de 16 que hay desde 160, guardar los múltiplos
en un arreglo
'''

n = 160 # Número de partida
multiplo = 16
longitud = 15

A = [] # Múltiplos

for i in range(longitud):
    A.append(n) # Ingresa el primer número al arreglo, que es el de partida
    n += multiplo

print(f"Los múltiplos de {multiplo} son: {", ".join([str(A[i]) for i in range(longitud)])}")