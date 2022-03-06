using Newtonsoft.Json;

if (args.Length < 1){
    throw new ArgumentNullException(nameof(args));
}
int maxLimit = int.Parse(args[0]);
string outputPath = "primes.json";
IList<int> primes = new List<int>();
for (int i = 2; i <= maxLimit; i++){
    bool isPrime = true;
    foreach (int prime in primes){
        if (i % prime == 0){
            isPrime = false;
            break;
        }
    }
    if (isPrime){
        primes.Add(i);
        Console.WriteLine(i);
    }
}
string primesJson = JsonConvert.SerializeObject(primes);
File.WriteAllText(outputPath, primesJson);