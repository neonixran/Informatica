import os

respuesta = "s"

while True:
    os.system("cls")
    binario = input("Ingrese un número binario: ")
    decimal = 0

    for i,v in enumerate(binario[::-1]):
        if int(v) == 1:
            decimal += i*2**i

    print(decimal)

    while True:
        respuesta = input("¿Quiere volver a calcular? (s/n): ").lower()

        if respuesta != "s" and respuesta != "n":
            print("Ingrese un valor válido")
        else:
            break