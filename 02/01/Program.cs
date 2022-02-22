Assembly? entryAssembly = Assembly.GetEntryAssembly();
if (entryAssembly == null) return;

foreach(AssemblyName assemblyName in entryAssembly.GetReferencedAssemblies()){
    Assembly assembly = Assembly.Load(assemblyName);
    int methodCount = 0;
    foreach (TypeInfo typeInfo in assembly.DefinedTypes){
        methodCount += typeInfo.GetMethods().Count();
    }
    Console.WriteLine($"{assembly.DefinedTypes.Count()} types with {methodCount} methods in {assemblyName} assembly.");
}