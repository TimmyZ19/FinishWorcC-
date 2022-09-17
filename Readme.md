 # Итоговая проверочная работа
 ## Задача:
 Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте исполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

 Примеры:
 - ["hello", "2", "world", ":-)"]->["2", ":-)"]
- ["1234", "1567", "-2", "computer science"]->["-2"]
- ["Russia", "Denmark", "Kazan"]->[]

## Решение:
1. Задаем первоначальный массив *arrayString*  и  *lessLength* - длину строк, которые должны быть добавлены в новый массив, меньше или равна
2. В заданном массиве *arrayString* считаем количество строк, длина которых меньше или равна *lessLength* => *CountWordsLength()*.
3. Создаем массив *arrayResult*, длина которого равна значению, полученному в шаге 2
4. Массив *arrayResult* заполняем строками из первоначального массива *arrayString*, длина которых меньше или равна *lessLength*.
5. Вывод результата