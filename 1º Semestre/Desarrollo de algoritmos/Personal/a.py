def contar_letras(palabra):
    palabra = str(palabra)
    
    a = 0
    for i in palabra:
        if str(i).lower() == "a":
            a += 1
    
    return a

print(contar_letras("Hola que tal esta ella"))