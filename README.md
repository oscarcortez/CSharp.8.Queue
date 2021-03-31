# CSharp.8.Queue

declarar una cola:
```csharp
Queue<string> numbers = new Queue<string>();
```

agregar: Enqueue
```csharp
numbers.Enqueue("one");
numbers.Enqueue("two");
numbers.Enqueue("three");
numbers.Enqueue("four");
numbers.Enqueue("five");
numbers.Enqueue("six");
```

obtener y eliminar al mismo tiempo:
```csharp
Console.WriteLine($"dequeue2 {numbers.Dequeue()}");
```

solo obtener sin eliminar: 
```csharp
Console.WriteLine($"peek3: {numbers.Peek()}");
```
