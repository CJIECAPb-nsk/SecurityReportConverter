using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using SecurityReportConverter.Services.Data;
using SharpCompress.Readers;

namespace SecurityReportConverter.Services
{
	public class LoaderService
	{
		public EventsEvent[] LoadData(string path)
		{
			var directoryInfo = new DirectoryInfo(path);
			var files = directoryInfo.GetFiles("*.rar");
			var result = new List<EventsEvent>();
			foreach (var file in files)
			{
				using (var stream = File.OpenRead(file.FullName))
				{
					var reader = ReaderFactory.Open(stream);
					while (reader.MoveToNextEntry())
					{
						if (reader.Entry.IsDirectory || !reader.Entry.Key.EndsWith("Events.xml"))
						{
							continue;
						}

						using (var memoryStream = new MemoryStream())
						{
							reader.WriteEntryTo(memoryStream);
							memoryStream.Seek(0, SeekOrigin.Begin);
							result.AddRange(Deserialize(memoryStream));
						}
					}
				}
			}

			return result.ToArray();
		}

		private EventsEvent[] Deserialize(MemoryStream stream)
		{
			var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
			var serializer = new XmlSerializer(typeof(Events));
			var settings = new XmlWriterSettings
			{
				Indent = true,
				OmitXmlDeclaration = false
			};

			return (serializer.Deserialize(stream) as Events)?.Event ?? Array.Empty<EventsEvent>();
		}
	}
}
