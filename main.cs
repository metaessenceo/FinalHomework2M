string[] inputArray = {"hello", "2", "world", ":-)"};
string[] outputArray = new string[inputArray.Length];

for (int i = 0; i < inputArray.Length; i++) {
    string element = inputArray[i];

    if (element.Length <=3) {
        Console.WriteLine(element);

        outputArray[i] = element;
    }
}
