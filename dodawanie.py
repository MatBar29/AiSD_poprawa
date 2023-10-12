import numpy

num1 = input("liczba1: ")
num2 = input("liczba2: ")

res1 = [int(x) for x in str(num1)]
res2 = [int(x) for x in str(num2)]

dlugosc1 = len(res1)
dlugosc2 = len(res2)

jeden = res1[0] + res2[0]
dwa = res1[1] + res2[1]
trzy = res1[2] + res2[2]

wynik = []

wynik.append(jeden)
wynik.append(dwa)
wynik.append(trzy)

if wynik[2] > 10:
    nowy = wynik[2] - 10
    wynik[2] = nowy
    wynik[1] = wynik[1] + 1
if wynik[2] == 10:
    nowy = 0
    wynik[2] = 0
    wynik[1] = wynik[1] + 1
if wynik[1] > 10:
    nowy = wynik[1] - 10
    wynik[1] = nowy
    wynik[0] = wynik[0] + 1
if wynik[1] == 10:
    nowy = 0
    wynik[1] = nowy
    wynik[0] = wynik[0] + 1
if wynik[0] > 10:
    nowy = wynik[0] - 10
    wynik[0] = nowy
    wynik.insert(0,1)
if wynik[0] == 10:
    nowy = 0
    wynik[0] = nowy
    wynik.insert(0,1)

print(wynik)
