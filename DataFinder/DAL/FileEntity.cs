using System;
using System.Collections.Generic;
using System.Text;

namespace DataFinder.DAL
{
    /// <summary>
    /// сущность нашего приложения
    /// </summary>
    class FileEntity
    {
        public FileEntity(Guid id, string name, string path)
        {
            this.id = id;
            Name = name;
            Path = path;
        }

        public Guid id {get; set;}
        
        public string Name { get; set; }
        
        public string Path { get; set; }
    }
}
