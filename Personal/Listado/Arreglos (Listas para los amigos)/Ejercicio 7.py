'''
Se quiere realizar un programa que lea por teclado las 5 notas obtenidas por un alumno
(comprendidas entre 1.0 y 7.0). A continuación debe mostrar todas las notas, la nota media,
la nota más alta que ha sacado y la menor.
'''

notas = []

for i in range(0, 5):
    notas.append(float(input(f"Ingrese nota {i+1}: ")))

promedio = 0
for i in range(0, 5):
    promedio += notas[i]

print(f"Su nota mínima es {min(notas)}, su promedio es {promedio/len(notas):.1f} y su nota máxima es {max(notas)}")