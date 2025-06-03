'''
Crear un arreglo (lista) de de 10 números, imprimiendo los multiplos de 7 partiendo desde el 700.
'''

longitud = 10
multiplos = []

n = 700 # Número de partida
for i in range(longitud):
    multiplos.append(n)
    n += 7 # n = n + 7 | Múltiplos de 7

print(f"Los multiplos son : {", ".join([str(i) for i in multiplos])}")
