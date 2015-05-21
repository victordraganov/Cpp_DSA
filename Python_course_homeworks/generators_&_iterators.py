__author__ = 'Veke'

import math
import string


def fibonacci():
    a, b = 1, 1
    while 1:
        yield a
        temp = a
        a = b
        b += temp
        

def primes():
    yield 2
    prime = 3
    is_prime = True
    while 1:
        for divisor in range(2, int(math.sqrt(prime) + 1)):
            if prime % divisor == 0:
                is_prime = False
                break
        if is_prime:
            yield prime
        is_prime = True
        prime += 1


def alphabet(code=None, letters=None):
    latin = string.ascii_lowercase
    cyrillic = 'абвгдежзийклмнопрстуфхцчшщъьюя'
    count = 0
    if letters is None:
            if code == 'lat':
                iterator = iter(latin)
            if code == 'bg':
                iterator = iter(cyrillic)
    else:
        iterator = iter(letters)
    while 1:
        yield next(iterator)