namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel.SeedData.Base
{
    public interface IFileImport<out TRecord>
    {
        TRecord[] GetRecords();
    }
}
