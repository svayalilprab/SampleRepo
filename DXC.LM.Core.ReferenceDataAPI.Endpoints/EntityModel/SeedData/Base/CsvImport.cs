using System.IO;
using System.Linq;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel.SeedData.Base
{
    public abstract class CsvImport<TRecord> : IFileImport<TRecord>
    {
        protected const char FieldSeparator = ',';

        private readonly string _filePath;


        protected CsvImport(string filePath)
        {
            _filePath = filePath;
        }

        public TRecord[] GetRecords()
        {
            var fileLines = File.ReadAllLines(_filePath);
            var records =  fileLines.Select(CreateRecord).ToArray();

            return records;
        }

        protected abstract TRecord CreateRecord(string arg);
    }
}
