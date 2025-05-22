'''
Escribir un programa que almacene las asignaturas de un curso (por ejemplo Matemáticas, Física,
Química, Historia y Lengua) en una lista, pregunte al usuario la nota que ha sacado en cada
asignatura y elimine de la lista las asignaturas aprobadas. Al final el programa debe mostrar
por pantalla las asignaturas que el usuario tiene que repetir.
'''

asignaturas = {"Matemáticas": 1, "Física": 1, "Química": 1, "Historia": 1, "Lengua": 1} # {Asignatura: Nota}

# Pregunta por la nota de cada asignatura
for asignatura in list(asignaturas):
    while True:
        try:
            nota = float(input(f"Ingrese la nota de {asignatura}: "))

            if nota < 1 or nota > 7:
                print("Nota fuera de rango")
                continue
            elif nota > 4:
                del asignaturas[asignatura] # Eliminar elemento del diccionario
            else:
                asignaturas[asignatura] = nota # Actualizar lista
            break
        except ValueError:
            print("Ingrese solo valores válidos")
print("\n")
# Imprime la nota de todas las asignaturas
for asignatura in asignaturas:
    print(f"Debe repetir {asignatura} ya que obtuvo un {asignaturas[asignatura]}")