using PLM.SharpSvnProxy;
using System;
using System.IO;
using System.Xml.Serialization;

namespace PLM.Start_commit
{
    internal static class SerializationHelper
	{
		public static string XmlSerialization(CommitFile[] value)
		{
			if (value == null) throw new ArgumentNullException(nameof(value));

			XmlSerializer serializer = new XmlSerializer(typeof (CommitFile[]));

			using (StringWriter writer = new StringWriter())
			{
				serializer.Serialize(writer, value);
				return writer.ToString();
			}
		}

	    public static CommitFile[] XmlDeserialization(string value)
	    {
			if (value == null) throw new ArgumentNullException(nameof(value));
		    if (value.Length == 0) return new CommitFile[0];

			XmlSerializer serializer = new XmlSerializer(typeof(CommitFile[]));

			using (StringReader writer = new StringReader(value))
			{
				return (CommitFile[])serializer.Deserialize(writer);
			}
	    }
    }
}
