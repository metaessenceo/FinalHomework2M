string[] inputArray = {"hello", "2", "world", ":-)"};

for (int i = 0; i < inputArray.Length; i++) {
    string element = inputArray[i];

    if (element.Length <=3) {
        Console.WriteLine(element);
    }

}
