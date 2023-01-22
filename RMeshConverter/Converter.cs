using MeshConverter.Core;
using MeshConverter.Core.Math;

namespace MeshConverter.Plugins.RMeshConverter
{
    public class Converter : BaseConverter
    {
        public string Name() { return "SCP:CB RMesh"; }
        
        public List<string> FileExtensions()
        {
            return new List<string> { ".rmesh" };
        }


    }
}