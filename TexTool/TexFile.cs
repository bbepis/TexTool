using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace TexTool
{
	public class TexFile
	{
		protected const string MAGIC = "CM3D2_TEX";

		public string InternalPath { get; set; }

		public TextureFormat Format { get; set; }

		public byte[] Data { get; set; }

		public Size Size { get; set; }

		public TexFile(string path, TextureFormat format, Size size)
		{
			InternalPath = path;
			Format = format;
			Size = size;
		}

		public static TexFile ReadFile(Stream stream)
		{
			BinaryReader binaryReader = new BinaryReader(stream, Encoding.UTF8);
			string text = binaryReader.ReadString();
			if (text != MAGIC)
			{
				throw new InvalidDataException("This is not a TEX file.");
			}

			int version = binaryReader.ReadInt32();
			string path = binaryReader.ReadString();
			int width = 0;
			int height = 0;
			TextureFormat textureFormat = TextureFormat.ARGB32;
			//Rect[] array = null;
			if (1010 <= version)
			{
				if (1011 <= version)
				{
					throw new NotSupportedException("1011 format .TEX files are not supported.");

					//int num2 = binaryReader.ReadInt32();
					//if (0 < num2)
					//{
					//	array = new Rect[num2];
					//	for (int i = 0; i < num2; i++)
					//	{
					//		float x = binaryReader.ReadSingle();
					//		float y = binaryReader.ReadSingle();
					//		float width2 = binaryReader.ReadSingle();
					//		float height2 = binaryReader.ReadSingle();
					//		array[i] = new Rect(x, y, width2, height2);
					//	}
					//}
				}

				width = binaryReader.ReadInt32();
				height = binaryReader.ReadInt32();
				textureFormat = (TextureFormat)binaryReader.ReadInt32();
			}

			int dataLength = binaryReader.ReadInt32();

			var data = new byte[dataLength];
			binaryReader.Read(data, 0, dataLength);

			if (version == 1000)
			{
				width = data[16] << 24 | data[17] << 16 | data[18] << 8 | data[19];
				height = data[20] << 24 | data[21] << 16 | data[22] << 8 | data[23];
			}

			TexFile file = new TexFile(path, textureFormat, new Size(width, height))
			{
				Data = data
			};

			return file;
		}

		public void WriteFile(Stream stream)
		{
			using (var writer = new BinaryWriter(stream, Encoding.UTF8))
			{
				writer.Write(MAGIC);
				writer.Write(1010);
				writer.Write(InternalPath);
				writer.Write(Size.Width);
				writer.Write(Size.Height);
				writer.Write((int)Format);

				writer.Write(Data.Length);
				writer.Write(Data);
			}
		}
	}

	public enum TextureFormat
	{
		RGB24 = 3,
		ARGB32 = 5,
		DXT1 = 11,
		DXT5 = 12,
		BC7 = 25,
	}
}
