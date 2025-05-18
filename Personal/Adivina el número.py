import random

repeat = "s"
levels = {
    1: {"attempts": 10},
    2: {"attempts": 5},
    3: {"attempts": 3}
}

while repeat == "s":
    level = int(input("Nivel de dificultad\n\t1: fácil (10 intentos)\n\t2: medio (5 intentos)\n\t3: díficil (3 intentos)\nIngrese el nivel: "))
    
    attempt = 0
    nrandom = random.randint(1, 100)

    while attempt < levels[level]["attempts"]:
        try:
            number = int(input(f"Ingresa tu número: "))

            if number < 1 or number > 100:
                print("\t[!] Sólo un número de 1 a 100")
                continue
            else:
                attempt += 1

                if attempt == levels[level]["attempts"]:
                    print(f"Perdiste, el número era {nrandom}")
                else:
                    if nrandom > number:
                        print("Es mayor")
                        continue 
                    elif nrandom < number:
                        print("Es menor")
                        continue
                    elif number == nrandom:
                        print(f"Ganaste en {attempt} intentos")
        except ValueError:
            print("\t[!]Ingrese un número válido")
            continue

        repeat = input("¿Quiere volver a jugar? (s/n): ").lower()