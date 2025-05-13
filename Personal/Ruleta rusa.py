import sys
import random
repeat = "s"

while repeat == "s":
    number = int(input(f"Ingrese un número del 1 al 10: "))
    nrandom = random.randint(1, 10)

    if number == nrandom:
        print("Ganaste")
    else:
        print(f"Perdiste, el número era {nrandom}")

    repeat = input("¿Quiere volver a jugar? (s/n): ").lower()