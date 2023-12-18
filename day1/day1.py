import re

with open("input") as f:
    adatok = f.read().strip()


def kalibracio(adat):
    sorok = adatok.split("\n")
    sor_szamok = [re.findall("\d", x) for x in sorok]
    return sum(int(n[0] + n[-1]) for n in sor_szamok)


# Part 1
print(kalibracio(adatok))

# Part 2
adatok = (
    adatok.replace("one", "one1one")
    .replace("two", "two2two")
    .replace("three", "three3three")
    .replace("four", "four4four")
    .replace("five", "five5five")
    .replace("six", "six6six")
    .replace("seven", "seven7seven")
    .replace("eight", "eight8eight")
    .replace("nine", "nine9nine")
)
print(kalibracio(adatok))