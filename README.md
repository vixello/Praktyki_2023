# Praktyki_2023

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
