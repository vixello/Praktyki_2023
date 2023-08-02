# Praktyki_2023
## 02.08.2023
## Odpowiedź na pytanie do zadania 1

**Przetestowanie zachowanie krzywej Lissajous dla różnych wartości początkowych time. Na przykład 1000, 10_000, 100_000, 500_000, 1_000_000, 8_000_000.** 

**Jak to zmienia zachowanie obiektu?**

**Jakie ma to konsekwencja przy tworzeniu gier?**


Ruch obiektu B rozpoczyna się z innego miejsca na krzywej przy każdej zmianie wartości. Wizualnie porusza się podobnie aż do wartości (z podanych przykładowo) 100 000 włącznie. Wyniki obliczeń ( time += Time.deltaTime * movementSpeed;) są jednak mniej dokładne i można to też zauważyć dla mniejszej wartości 10 000, kiedy wyniki powtarzają się np. 2 razy pod rząd. Im większa wartość początkowa, tym sytuacja się pogarsza i np. dla 100 000 potwarzają się już nawer kilkanaście razy, dla 500 000 kilkaset, kilka tysięcy razy, można zaobserwować też niepłynny ruch obiektu. Dla 1 000 000 i 8 000 000 wyniki powtarzają się tak często, że ruch obiektu prawie nie występuje. 

Ponieważ w grach ważne jest to, żeby rozgrywka /ruch były płynne i responsywne, a nie przerywane (o ile nie jest to celowe), powinno się unikać sytuacji, kiedy dodaje lub odejmuje się liczby znacznie różniące się rzędem wielkości, tak jak w przypadku time += Time.deltaTime * movementSpeed; dla dużych wartości początkowych time.

## Odpowiedź na pytanie do zadania 2

**Czy wynik obliczeń jest taki sam przy kolejnych uruchomieniach programu?**

**Czy wynik obliczeń jest taki sam na PC i na Androidzie?**

**Jakie to ma konsekwencja przy tworzeniu gier?**

1. Tak, wynik obliczeń jest taki sam ze względu na użycie własnej stałej wartości seed.
2. Wygenerowane liczby są takie same dla PC i Androida
3. Jeżeli sami ustawimy wartość seed, możemy użyć wygenerowanych za każdym razem takich samych danych do tworzenia poziomów (lub też innych części gry) generowanych proceduralnie. Dzięki temu możemy wygenerwoać x poziomów dla x seedów i zaoszczędzić na wykorzystywanej przez grę pamięci przez zapisanie owych poziomów w postaci zmiennych int, czyli zapisanych wartości seedó

## 01.08.2023
## Odpowiedź na pytanie do zadania 1
## "Po 1 min powinien wyskoczyć błąd":

tutaj pokazane ostatnie 11 sek animacji

![ezgif com-video-to-gif (1)](https://github.com/vixello/Praktyki_2023/assets/79693214/66940a69-4c82-4ceb-97b7-12db46f8763b)


## Czym ta sytuacja różni się od normalnego działania GC:

"Unity runs the garbage collector. When the garbage collector runs, it examines all objects in the heap, and marks for deletion any objects that your application no longer references. Unity then deletes the unreferenced objects, which frees up memory.

[...] Unity’s scripting backends
can only access a reference item on the heap as long as there are still reference variables that can locate it. If all references to a memory block are missing (if the reference variables have been reassigned or if they’re local variables that are now out of scope) then the garbage collector can reallocate the memory it occupied."
src: https://docs.unity3d.com/Manual/performance-garbage-collector.html

~~Usuwając funkcji Destroy usuwany obiekt wciąż pozostaje w pamięci dopóki nie zwolni jej GC.
Ponieważ istnieje referencja do usuwanego obiektu, nie zostanie on oznaczony przez GC jako gotowy do usunięcia i zwolnienia pamięci, pozostanie w niej, dopóki wszystkie odniesienia do niego nie zostaną usunięte.~~

Poprawka:
Funkcja dsetroy oprócz działania jako delete ale także ustawia referencję do usuwanego gameobjectu jako null. W GC obiekt normalnie istnieje/ żyje tak długo, jak długo są do niego referencje.
