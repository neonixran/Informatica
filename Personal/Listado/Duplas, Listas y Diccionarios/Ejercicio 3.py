'''
Escribir un programa que almacene las asignaturas de un curso (por ejemplo Matemáticas, Física,
Química, Historia y Lengua) en una lista, pregunte al usuario la nota que ha sacado en cada
asignatura, y después las muestre por pantalla con el mensaje En <asignatura> has sacado <nota>
donde <asignatura> es cada una des las asignaturas de la lista y <nota> cada una de las
correspondientes notas introducidas por el usuario.
'''

asignaturas = {"Matemáticas": 1, "Física": 1, "Química": 1, "Historia": 1, "Lengua": 1} # {Asignatura: Nota}

# Pregunta por la nota de cada asignatura
for asignatura in asignaturas:
    while True:
        try:
            nota = float(input(f"Ingrese la nota de {asignatura}: "))

            if nota < 1 or nota > 7:
                print("Nota fuera de rango")
                continue

            asignaturas[asignatura] = nota
            break
        except ValueError:
            print("Ingrese solo valores válidos")
print("\n")
# Imprime la nota de todas las asignaturas
for asignatura in asignaturas:
    print(f"En {asignatura} has sacado {asignaturas[asignatura]}")