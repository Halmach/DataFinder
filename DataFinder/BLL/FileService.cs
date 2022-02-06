using DataFinder.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFinder.BLL
{
    /// <summary>
    /// Поведение нашей бизнес модели
    /// </summary>
    class FileService
    {
        public FileRepository fileRepository { get; }
        
        public FileService()
        {
            this.fileRepository = new FileRepository();
        }

        public IEnumerable<File> GetAllFiles()
        {
            return fileRepository.GetFileByDirectory().ToList().Select(fileEntity => new File(fileEntity));
        }

        public File GetFileByFileName(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
                throw new BusinessRuleException("Введите корректное значение!");

            var fileEntity = fileRepository.GetFileByName(fileName);
            if (fileEntity is null)
                throw new BusinessRuleException("Файл с указанным именем не обнаружен");

            return new File(fileEntity);
        }
    }
}
