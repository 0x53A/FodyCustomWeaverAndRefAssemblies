using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weavers
{
    public class NamedWeaver
    {
        public ModuleDefinition ModuleDefinition { get; set; }

        public Action<string> LogWarning { get; set; }

        public void Execute()
        {
            LogWarning("HELLO from 'NamedWeaver'");
            //ModuleDefinition.Types.Add(new TypeDefinition("MyNamespace", "MyType", TypeAttributes.Public, ModuleDefinition.Import(typeof(object))));
        }
    }
}
