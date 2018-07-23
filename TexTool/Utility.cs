using System.IO;

namespace TexTool
{
	public static class Utility
	{
		public static byte[] ToBytes(this Stream stream)
		{
			byte[] buffer = new byte[stream.Length - stream.Position];

			stream.Read(buffer, 0, (int)(stream.Length - stream.Position));

			return buffer;
		}
	}
}
