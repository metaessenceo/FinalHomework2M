string[] inputArray = {"hello", "2", "world", ":-)"};

for (int i = 0; i < inputArray.Length; i++) {
    string element = inputArray[i];
    
    Console.Write(element.Length);
    Console.Write(" ");
    Console.WriteLine(element);
}
