
string[] filterByMaxLength(string[] inputArray, maxLength) {
    string[] outputArray = new string[inputArray.Length];

    for (int i = 0; i < inputArray.Length; i++) {
        string element = inputArray[i];

        if (element.Length <= maxLength) {
            outputArray[i] = element;
        }
    }
    return outputArray;
}


void writeArray(string[] inputArray) {
    for (int i = 0; i < inputArray.Length; i++) {
        Console.WriteLine(inputArray[i]);
    }
}

string[] inputArray = {"hello", "2", "world", ":-)"};
string[] outputArray = filterByMaxLength(inputArray, 3);
writeArray(outputArray);
