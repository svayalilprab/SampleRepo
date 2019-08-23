using DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel.SeedData.Base;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel.SeedData
{
    public class ClaimsValueOfLossNKImport : CsvImport<ClaimsValueOfLossNotKnown>
    {
        private static class ColumnIndex
        {
            private static int _count = 0;

            public static int Id { get; } = _count++;
            public static int Key { get; } = _count++;
            public static int Value { get; } = _count++;
        }


        public ClaimsValueOfLossNKImport(string filePath)
            : base(filePath)
        {
        }

        protected override ClaimsValueOfLossNotKnown CreateRecord(string fileLine)
        {
            var values = fileLine.Split(FieldSeparator);

            return new ClaimsValueOfLossNotKnown
            {
                ID =  int.Parse(values[ColumnIndex.Id]),
                Key = values[ColumnIndex.Key],
                Value = values[ColumnIndex.Value]
            };
        }
    }
}
