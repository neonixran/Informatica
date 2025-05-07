print("Este programa calcula el IMC (Índice de Masa Corporal)")

rep = "s" # "s": Continua ejecutandose, "n": Termina el programa (puede ocurrir que con cualquier letra termina)

# Comprueba que mientras la variable rep sea igual a "s" se siga ejecutando
while rep.lower() == "s":
    masa = input("Ingrese su peso (kg): ")
    estatura = input("Ingrese su estatura (cm): ")

    # Comprobar que el peso (masa) y estatura estén dentro del rango permitido y sean numéricos
    while (not masa.isnumeric() or not estatura.isnumeric()) or (float(masa) <= 0 or float(masa) > 500) or (float(estatura) <= 0 or float(estatura) > 250):
        print("[!] Debe ingresar valores válidos.")
        masa = input("Ingrese su peso (kg): ")
        estatura = input("Ingrese su estatura (cm): ")

    # Cálculo del imc, conversión de centímetros a metros
    imc = float(masa) / ((float(estatura) / 100) ** 2)

    # Tipos de peso
    if imc < 18:
        print("Bajo peso")
    elif imc < 25:
        print("Peso normal")
    elif imc < 30:
        print("Exceso de peso")
    elif imc < 35:
        print("Obesidad grado I")
    elif imc < 40:
        print("Obesidad grado II")
    elif imc < 45:
        print("Obesidad grado III (mórbida)")
    elif imc > 50:
        print("Obesidad grado IV (extrema)")
    else:
        print("No fue posible calcular")

    print(f"Su IMC es: {imc:.1f}")

    rep = input("\n¿Quiere calcular de nuevo? (s/n): ")