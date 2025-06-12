nota_minima = 5.5

def PromEv(cantidad: int, promedio_actual: float = 0):
    promedio = promedio_actual
    porcentaje_restante = 1.0

    for i in range(cantidad):
        while True:
            try:
                nota = input(f"Ingrese nota de la sub-evaluación #{i+1}: ")
                
                if not nota:
                    nota_faltante = True
                    break
                    
                f_nota = float(nota)
                
                if type(f_nota) == "float" and (f_nota < 1 or f_nota > 7):
                    print("Ingrese una nota válida!")
                    continue
                break
            except ValueError:
                print("Ingrese la nota como decimal!")
                continue

        while True:
            try:
                porcentaje = int(input(f"Ingrese porcentaje de la sub-evaluación #{i+1}: ")) / 100
                
                if porcentaje < 0.3 or porcentaje > 1:
                    print("Ingrese un porcentaje válido!")
                    continue
                porcentaje_restante -= porcentaje
                break
            except ValueError:
                print("Ingrese el porcentaje como entero!")
                continue

        if "nota_faltante" in locals() and nota_faltante:
            nota_necesaria = (nota_minima - promedio) / porcentaje

            if nota_necesaria < 1 or nota_necesaria > 7:
                print(f"No es posible alcanzar la nota mínima con los porcentajes restantes.")
            else:
                print(f"Debe obtener una nota de {nota_necesaria:.2f} en esta evaluación para alcanzar el mínimo.")

            return promedio
        else:
            promedio += f_nota * porcentaje

    return promedio

promedios = []

for i in range(3):
    cantidad = int(input(f"Ingrese la cantidad de sub-evaluaciones para la evaluación {i+1}: "))
    promedio = PromEv(cantidad)
    promedios.append(promedio)
    print()

nota_final = promedios[0] * 0.25 + promedios[1] * 0.35 + promedios[2] * 0.4
print(nota_final)