using DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel.SeedData.Base;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel.SeedData
{
    public class ClaimsCurrencyCsvImport : CsvImport<ClaimsCurrency>
    {
        private static class ColumnIndex
        {
            private static int _count = 0;

            public static int Id { get; } = _count++;
            public static int Code { get; } = _count++;
            public static int Currency { get; } = _count++;
        }


        public ClaimsCurrencyCsvImport(string filePath)
            : base(filePath)
        {
        }

        protected override ClaimsCurrency CreateRecord(string fileLine)
        {
            var values = fileLine.Split(FieldSeparator);

            return new ClaimsCurrency
            {
                ID =  int.Parse(values[ColumnIndex.Id]),
                Code = values[ColumnIndex.Code],
                Currency = values[ColumnIndex.Currency]
            };
        }
    }
}
