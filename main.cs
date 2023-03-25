
string[] filterByMaxLength(string[] inputArray, int maxLength) {
    string[] outputArray = new string[inputArray.Length];

    int outputArrayIndex = 0;
    for (int i = 0; i < inputArray.Length; i++) {
        string element = inputArray[i];

        if (element.Length <= maxLength) {
            outputArray[outputArrayIndex] = element;
            outputArrayIndex++;
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
