using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshConverter.Core
{
    public interface BaseConverter
    {
        public string Name();
        public List<string> FileExtensions();

        public Model LoadModel(string path);
        public void SaveModel(string path, Model model);
    }
}
