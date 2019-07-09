using UnityEngine;
using xLayout.Definitions;

namespace xLayout.TypesConstructors
{
    public class PrefabConstructor : TypeConstructor<PrefabElement>
    {
        protected override GameObject Install(GameObject go, PrefabElement element, IReadOnlyLayoutContext context)
        {            
            return go;
        }
    }
}