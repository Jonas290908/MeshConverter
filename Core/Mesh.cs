using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MeshConverter.Core.Math;

namespace MeshConverter.Core
{
    public class Vertex
    {
        public Vector3 position { get; set; }
        public Vector3 normal { get; set; }

        public Vector2 uv { get; set; }
    }
    public class Mesh
    {
        public List<Vertex> vertices { get; set; }
        public List<uint> triangles { get; set; }
    }
}
