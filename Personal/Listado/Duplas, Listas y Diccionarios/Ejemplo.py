'''
    Mutable: Puede modificarse luego de crearse.
    Inmutable: No puede modificarse luego de crearse.
'''

lista = ["Pera", "Manzana", "Platano"] # Mutable
dupla = ("Pera", "Manzana", "Platano") # Inmutable
diccionario = {"Fruta 1": "Pera", "Fruta 2": "Manzana", "Fruta 3": "Platano"} # Mutable, {Indice: Valor}

print("\tLista")
for i in lista:
    print(f"- {i}")

print(f"\nAntiguo indice 0: {lista[0]}\n¿Pera está en la lista?: {"Pera" in lista}")
lista[0] = "Durazno" # Se cambia el dato "Pera" por "Durazno"
print(f"Nuevo indice 0: {lista[0]}\n¿Pera está en la lista?: {"Pera" in lista}")
print("---------------------------------------------------------------")
print("\tDupla")
for i in dupla:
    print(f"- {i}")

print(f"\nIndice 0: {dupla[0]}")
print(f"\n¿Durazno está en la dupla?: {"Durazno" in dupla}\n¿Pera está en la dupla?: {"Pera" in dupla}")
print("---------------------------------------------------------------")
print("\tDiccionario")
for i in diccionario:
    print(f"- [{i}] : {diccionario[i]}")

print(f"\nAntiguo indice \"Fruta 1\": {diccionario["Fruta 1"]}")
diccionario["Fruta 1"] = "Durazno" # Se cambia el dato "Pera" por "Durazno"
print(f"Nuevo indice \"Fruta 1\": {diccionario["Fruta 1"]}")