# Программа итогового проекта
## Блок-схема проекта 
Создал две схемы: 
+ **Основная схема:**

 В ней описан основной алгоритм работы программы. Сначала программа запрашивает пользователя ввести количество слов. Далее происходит сам ввод пользователем слов. 

Если количество слов не сходится с указанным количеством, то программа сообщает об этом и завершает выполнение.

Если же ввод произвелся верно, то происходит вывод исходного массива и выполнение двух методов, блок-схема которых реализована отдельно. 

+ Блок-схема методов:

В данной блок-схеме реализуется алгоритм заполнения нового массива и вывод его в терминал.

## Код программы

Код начинается с объявления двух массивов _origArray_ и _newArray_. Длина начального массива задается пользователем _num_. Длина нового массива зависит от длины изначального массива.

Создадим так же переменную _words_ с типом данных _string_. В нее и запишутся все слова через запятую. Далее, указав в методе _Split()_ разделитель запятую, получим массив _origArray_.

Добавив перерменную _count_, проверим условие на количество вводимых слов пользователем: _count != num_. При этом инкремент счетчика происходит только тогда, когда значение элемента массива не равно пустой строке.

Остается использовать методы _FillNewArray_ и _PrintArray_, которые заполнят новый массив, исходя из условия (_if(origArray[i] < 3)_), и выведут его на экран.