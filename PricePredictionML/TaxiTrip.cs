// <Snippet1>
using Microsoft.ML.Data;
// </Snippet1>

namespace TaxiFarePrediction
{
    // <Snippet2>
    public class TaxiTrip
    {
        [LoadColumn(0)] public float AmbientTemperature { get; set; }
        [LoadColumn(1)] public float ModuleTemperature { get; set; }
        [LoadColumn(2)] public float Irradiation { get; set; }
        [LoadColumn(3)] public float DCPower { get; set; }
    }

    public class TaxiTripFarePrediction
    {
        [ColumnName("DCPower")]
        public float DCPower;
    }
    // </Snippet2>
}