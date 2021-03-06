# FixedThreadPool

Требуется реализация класса на языке C#, аналогичного FixedThreadPool в Java, со следующими требованиями: 

* В конструктор этого класса должно передаваться количество потоков, которые будут выполнять задачи. 
* Интерфейс класса должен предоставлять методы: `bool Execute(Task task, Priority priority)` и `void Stop()` 
* Интерфейс `Task` должен содержать один метод: void Execute(), который вызывается в произвольном потоке. 
* Тип `Priority` — это перечисление из трёх приоритетов: HIGH, NORMAL, LOW. При этом во время выбора следующего задания из очереди действуют такие правила: на три задачи с приоритетом HIGH выполняется одна задача с приоритетом NORMAL, задачи с приоритетом LOW не выполняются, пока в очереди есть хоть одна задача с другим приоритетом. 
* До вызова метода `Stop()` задачи ставятся в очередь на выполнение и метод `bool Execute(Task task, Priority priority)` сразу же возвращает true, не дожидаясь завершения выполнения задачи; а после вызова Stop() новые задачи не добавляются в очередь на выполнение, и метод `bool Execute(Task task, Priority priority)` сразу же возвращает false. 
* Метод `Stop()` ожидает завершения всех текущих задач (не очищая очередь).
