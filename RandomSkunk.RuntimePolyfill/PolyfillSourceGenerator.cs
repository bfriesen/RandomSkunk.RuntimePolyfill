using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Reflection;
using System.Text;

namespace RandomSkunk.RuntimePolyfill;

[Generator]
public class PolyfillSourceGenerator : ISourceGenerator
{
    private static readonly string _resourceNamePrefix = typeof(PolyfillSourceGenerator).Namespace + ".";

    public void Initialize(GeneratorInitializationContext context)
    {
    }

    public void Execute(GeneratorExecutionContext context)
    {
        // The source files from the shared project are included in the assembly as embedded resources.
        var assembly = Assembly.GetExecutingAssembly();
        var resourceNames = assembly.GetManifestResourceNames();

        foreach (var resourceName in resourceNames)
        {
            using var stream = assembly.GetManifestResourceStream(resourceName);
            using var reader = new StreamReader(stream);
            
            var sourceCode = reader.ReadToEnd();
            var sourceName = resourceName.Substring(_resourceNamePrefix.Length);
            
            // Add each source file to the compilation.
            context.AddSource(sourceName, SourceText.From(sourceCode, Encoding.UTF8));
        }
    }
}
