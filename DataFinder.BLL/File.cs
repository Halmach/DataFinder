using DataFinder.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFinder.BLL
{
    /// <summary>
    /// класс нашей бизнес-модели
    /// </summary>
    public  class File
    {
        public Guid Id { get; }
        
        public string Name { get; }

        public string Path { get; }

        public File (FileEntity fileEntity)
        {
            this.Id = fileEntity.id;
            this.Name = fileEntity.Name;
            this.Path = fileEntity.Path;
        }
    }
}
