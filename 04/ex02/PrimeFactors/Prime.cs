using System.Text;
using Newtonsoft.Json;

public class Prime{
    private HashSet<int> _primesHashSet;
    private int[] _primesArray;

    public Prime(string primesFilePath){
        string primesJson = File.ReadAllText(primesFilePath);
        HashSet<int>? primesHashSet = JsonConvert.DeserializeObject<HashSet<int>>(primesJson);
        int[]? primesArray = JsonConvert.DeserializeObject<int[]>(primesJson);
        if (primesHashSet == null || primesArray == null){
            throw new InvalidDataException("primes list is empty");
        }
        _primesHashSet = primesHashSet;
        _primesArray = primesArray;
    }

    public string PrimeFactors(int number){
        // number is a prime
        if (_primesHashSet.Contains(number)){
            return number.ToString();
        }

        // number is not a prime
        StringBuilder stringBuilder = new();
        int i = 0;
        while (!_primesHashSet.Contains(number) && i < _primesArray.Length){
            int testPrime = _primesArray[i];
            if (number % testPrime == 0){
                stringBuilder.Append("x");
                stringBuilder.Append(testPrime);
                number /= testPrime;
            }else{
                i++;
            }
        }
        stringBuilder.Append("x");
        stringBuilder.Append(number);
        stringBuilder.Remove(0,1);
        string? result = stringBuilder.ToString();
        if (result == null){
            throw new InvalidOperationException("null PrimeFactors result");
        }
        return result;
    }
}