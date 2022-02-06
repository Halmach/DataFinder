using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFinder.DAL
{
    /// <summary>
    /// репозиторий для нашей сущности
    /// </summary>
    class FileRepository
    {
        private IEnumerable <FileEntity> files { get; }

        public FileRepository()
        {
            files = new List<FileEntity>()
            {
                new FileEntity(Guid.NewGuid(), "Реферат.docx", Environment.CurrentDirectory + "/Docs/Реферат.docx"),
                new FileEntity(Guid.NewGuid(), "Отчет.docx", Environment.CurrentDirectory + "/Docs/Отчет.docx"),
                new FileEntity(Guid.NewGuid(), "Книга1.xls", Environment.CurrentDirectory +  "/Docs/Книга1.xls"),
                new FileEntity(Guid.NewGuid(), "Фото на документы.jpeg", Environment.CurrentDirectory + "/Docs/Фото на документы.jpeg"),
                new FileEntity(Guid.NewGuid(), "Архив.zip", Environment.CurrentDirectory + "/Docs/Архив.zip"),
            };
        }

        public IEnumerable<FileEntity> GetFileByDirectory()
        {
            return this.files;
        }

        public FileEntity GetFileByName(string fileName)
        {
            return this.files.FirstOrDefault(file => file.Name == fileName);
        }
        
    }
    
}
