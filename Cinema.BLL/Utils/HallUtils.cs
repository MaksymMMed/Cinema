using Cinema.BLL.DTOs.Halls;
using Newtonsoft.Json;

namespace Cinema.BLL.Utils;

public static class HallUtils
{
    public static string SerializeRowsData(IEnumerable<HallRowDataDto> rowsData)
    {
        return JsonConvert.SerializeObject(rowsData);
    }
    
    public static List<HallRowDataDto> DeserializeRowsData(string rowsData)
    {
        return JsonConvert.DeserializeObject<List<HallRowDataDto>>(rowsData) ?? [];
    }
}