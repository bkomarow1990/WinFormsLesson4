using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace EventsHW
{
    public abstract class ImportEvents
    {
        public string Path { get; set; }
        public abstract List<Event> Import();
        public ImportEvents(string path)
        {
            Path = path;
        }
    }
    public interface IEventsExported
    {
        public void Export(List<Event> ev);
    }
    public class JsonImporterEvents : ImportEvents
    {
        public override List<Event> Import()
        {
            string json = File.ReadAllText(Path);
            return JsonConvert.DeserializeObject<List<Event>>(json);
        }
        public JsonImporterEvents(string path)
        :base(path){

        }
    }
    public class WorkWithJsonEvent : JsonImporterEvents, IEventsExported
    {
        public WorkWithJsonEvent(string path)
        : base(path)
        {

        }
        public void Export(List<Event> ev)
        {
            File.WriteAllText( Path, JsonConvert.SerializeObject(ev));
        }
    }
}
