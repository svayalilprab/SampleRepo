using DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel.SeedData.Base;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel.SeedData
{
    public class ReferenceDataItemCsvImport : CsvImport<ReferenceDataItem>
    {
        private static class ColumnIndex
        {
            private static int _count = 0;

            public static int Id { get; } = _count++;
            public static int Path { get; } = _count++;
            public static int Key { get; } = _count++;
            public static int Value { get; } = _count++;
        }


        public ReferenceDataItemCsvImport(string filePath)
            : base(filePath)
        {
        }

        protected override ReferenceDataItem CreateRecord(string fileLine)
        {
            var values = fileLine.Split(FieldSeparator);

            return new ReferenceDataItem
            {
                ID =  int.Parse(values[ColumnIndex.Id]),
                Path = values[ColumnIndex.Path],
                Key = values[ColumnIndex.Key],
                Value = values[ColumnIndex.Value]
            };
        }
    }
}
