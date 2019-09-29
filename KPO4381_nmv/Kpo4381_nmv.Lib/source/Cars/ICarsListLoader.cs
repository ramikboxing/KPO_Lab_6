using System.Collections.Generic;

namespace Kpo4381_nmv.Lib
{
    public interface ICarsListLoader
    {
        List<Car> carsList { get; }
        LoadStatus status { get; }

        void Execute();
        void SetOfDeligate(OnLoadFileDelegate onAfterRowConvert);
    }
    /*public enum LoadStatus
    {
        None =-1,
        ReadingData =0,
        Success=1,
        ReadingError=2
    }*/
}