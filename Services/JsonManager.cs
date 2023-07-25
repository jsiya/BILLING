using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BILLING.Services;

public static class JsonManager<T> where T : class  //Jsona serialize ve deserialize etmek ucun
{
    public static void Serializer(string path, ObservableCollection<T> values)
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;
        if (values != null)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(values, options));
        }
    }
    public static ObservableCollection<T> Deserializer(string path, ObservableCollection<T> values)
    {
        using FileStream fs = new FileStream(path, FileMode.Open);
        if (fs.Length > 0) //file bosdusa error vermesin deye
            values = System.Text.Json.JsonSerializer.Deserialize<ObservableCollection<T>>(fs);
        if (values == null)
            values = new();
        return values;
    }
}
