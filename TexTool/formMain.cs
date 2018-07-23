using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ImageMagick;

namespace TexTool
{
	public partial class formMain : Form
	{
		public formMain()
		{
			InitializeComponent();
		}

		public TexFile currentFile = null;
		public string currentPath = string.Empty;

		public void Open(Stream stream)
		{
			currentFile = TexFile.ReadFile(stream);

			using (MagickImage image = new MagickImage(currentFile.Data))
				ReloadUI(image, currentFile.Format);
		}

		public void ReloadUI(MagickImage image, TextureFormat format)
		{
			txtPath.Text = currentFile.InternalPath;

			switch (format)
			{
				case TextureFormat.ARGB32:
					cmbFormat.SelectedIndex = 0;
					break;
				case TextureFormat.RGB24:
					cmbFormat.SelectedIndex = 1;
					break;
				case TextureFormat.DXT1:
					cmbFormat.SelectedIndex = 2;
					break;
				case TextureFormat.DXT5:
					cmbFormat.SelectedIndex = 3;
					break;
			}

			if (imgTexture.Image != null)
			{
				imgTexture.Image.Dispose();
				imgTexture.Image = null;
			}
			
			imgTexture.Image = image.ToBitmap();

			numX.Value = currentFile.Size.Width;
			numY.Value = currentFile.Size.Height;

			DetermineZoom();

			SetEnabled(true);
		}

		public void SetEnabled(bool value)
		{
			txtPath.Enabled = value;
			cmbFormat.Enabled = value;
			saveToolStripMenuItem.Enabled = value;
			saveAsToolStripMenuItem.Enabled = value;
			pNGToolStripMenuItem.Enabled = value;
			jPGToolStripMenuItem.Enabled = value;
			dDSToolStripMenuItem.Enabled = value;
			numX.Enabled = value;
			numY.Enabled = value;
			chkConvert.Enabled = value;
		}

		public void DetermineZoom()
		{
			if (imgTexture.Image == null)
				return;

			if (imgTexture.Image.Width > imgTexture.Width ||
			    imgTexture.Image.Height > imgTexture.Height)
				imgTexture.SizeMode = PictureBoxSizeMode.Zoom;
			else
				imgTexture.SizeMode = PictureBoxSizeMode.CenterImage;
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog
			{
				Filter = "Texture file (*.tex)|*.tex|All Files (*.*)|*.*"
			};

			if (open.ShowDialog() != DialogResult.OK)
				return;

			currentPath = open.FileName;
			Text = $"TexTool - {Path.GetFileName(currentPath)}";

			Open(open.OpenFile());
		}

		private void imgTexture_Resize(object sender, EventArgs e)
		{
			DetermineZoom();
		}

		#region Export

		public void Export(string filter, MagickFormat format)
		{
			SaveFileDialog save = new SaveFileDialog
			{
				Filter = filter + "|All Files (*.*)|*.*"
			};

			if (save.ShowDialog() != DialogResult.OK)
				return;

			if (format == MagickFormat.Png32 && currentFile.Format == TextureFormat.ARGB32
			    || format == MagickFormat.Jpeg && currentFile.Format == TextureFormat.ARGB32
			    || format == MagickFormat.Dds && (currentFile.Format == TextureFormat.DXT1 || currentFile.Format == TextureFormat.DXT5))
			{
				File.WriteAllBytes(save.FileName, currentFile.Data);
				return;
			}

			using (MagickImage image = new MagickImage(currentFile.Data))
			using (Stream stream = save.OpenFile())
			{
				image.Format = format;

				image.Write(stream);
			}
		}

		private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Export("PNG image (*.png)|*.png", MagickFormat.Png);
		}

		private void jPGToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Export("JPEG image (*.jpeg;*.jpg)|*.jpeg;*.jpg", MagickFormat.Jpeg);
		}

		private void dDSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Export("DDS texture (*.dds)|*.dds", MagickFormat.Dxt5);
		}

		#endregion

		#region Import

		public void Import()
		{
			OpenFileDialog open = new OpenFileDialog
			{
				Filter = "All supported image formats (*.png;*.jpg;*.jpeg;*.dds)|*.png;*.jpg;*.jpeg;*.dds|PNG image (*.png)|*.png|JPEG image (*.jpeg;*.jpg)|*.jpeg;*.jpg|DDS texture (*.dds)|*.dds|All Files (*.*)|*.*"
			};

			if (open.ShowDialog() != DialogResult.OK)
				return;

			byte[] data;

			using (var stream = open.OpenFile())
				data = stream.ToBytes();

			using (MagickImage image = new MagickImage(data))
			{
				TextureFormat format;

				switch (image.Format)
				{
					default:
					case MagickFormat.Png:
					case MagickFormat.Png32:
					case MagickFormat.Png24:
						format = TextureFormat.ARGB32;
						break;
					case MagickFormat.Jpeg:
					case MagickFormat.Jpg:
						format = TextureFormat.RGB24;
						break;
					case MagickFormat.Dxt1:
						format = TextureFormat.DXT1;
						break;
					case MagickFormat.Dds:
					case MagickFormat.Dxt5:
						format = TextureFormat.DXT5;
						break;
				}
				
				currentFile = new TexFile(Path.GetFileName(open.FileName), format, new Size(image.Width, image.Height));
				currentFile.Data = data;

				ReloadUI(image, format);
			}
		}

		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Import();
		}

		#endregion

		#region Save

		public void SetSaveFormat()
		{
			currentFile.InternalPath = txtPath.Text;

			TextureFormat targetFormat = TextureFormat.ARGB32;

			switch (cmbFormat.SelectedIndex)
			{
				case 0:
					targetFormat = TextureFormat.ARGB32;
					break;
				case 1:
					targetFormat = TextureFormat.RGB24;
					break;
				case 2:
					targetFormat = TextureFormat.DXT1;
					break;
				case 3:
					targetFormat = TextureFormat.DXT5;
					break;
			}

			if (chkConvert.Checked)
			{
				using (MagickImage image = new MagickImage(currentFile.Data))
				{
					if (currentFile.Size.Width != numX.Value ||
					    currentFile.Size.Height != numX.Height)
					{
						var geo = new MagickGeometry((int)numX.Value, (int)numY.Value);
						geo.IgnoreAspectRatio = true;
						
						image.Resize(geo);

						currentFile.Size = new Size((int)numX.Value, (int)numY.Value);
					}

					if (image.Format == MagickFormat.Png32 && targetFormat == TextureFormat.ARGB32
					    || image.Format == MagickFormat.Jpeg && targetFormat == TextureFormat.ARGB32
					    || image.Format == MagickFormat.Dds && (targetFormat == TextureFormat.DXT1 || targetFormat == TextureFormat.DXT5))
					{

					}
					else
					{
						switch (targetFormat)
						{
							case TextureFormat.ARGB32:
								image.Format = MagickFormat.Png;
								break;
							case TextureFormat.RGB24:
								image.Format = MagickFormat.Jpeg;
								break;
							case TextureFormat.DXT1:
								image.Format = MagickFormat.Dxt1;
								break;
							case TextureFormat.DXT5:
								image.Format = MagickFormat.Dxt5;
								break;
						}

						using (MemoryStream mem = new MemoryStream())
						{
							image.Write(mem);
							currentFile.Data = mem.ToArray();
						}
					}
				}
			}

			currentFile.Format = targetFormat;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (currentPath == "")
				return;

			SetSaveFormat();

			using (FileStream fs = new FileStream(currentPath, FileMode.Create))
				currentFile.WriteFile(fs);

			using (MagickImage image = new MagickImage(currentFile.Data))
				ReloadUI(image, currentFile.Format);
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog
			{
				Filter = "Texture file (*.tex)|*.tex|All Files (*.*)|*.*"
			};

			if (save.ShowDialog() != DialogResult.OK)
				return;

			SetSaveFormat();

			using (Stream fs = save.OpenFile())
				currentFile.WriteFile(fs);
			
			using (MagickImage image = new MagickImage(currentFile.Data))
				ReloadUI(image, currentFile.Format);
		}

		#endregion

		#region Batch

		private void importToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog
			{
				Filter = "All supported image formats (*.png;*.jpg;*.jpeg;*.dds)|*.png;*.jpg;*.jpeg;*.dds|PNG image (*.png)|*.png|JPEG image (*.jpeg;*.jpg)|*.jpeg;*.jpg|DDS texture (*.dds)|*.dds|All Files (*.*)|*.*",
				Multiselect = true
			};

			if (open.ShowDialog() != DialogResult.OK)
				return;

			foreach (string filename in open.FileNames)
			{
				using (FileStream fs = new FileStream(filename, FileMode.Open))
				{
					byte[] data = fs.ToBytes();

					using (MagickImage image = new MagickImage(data))
					{
						TextureFormat format;
						string internalPath = Path.GetFileName(filename);

						switch (Path.GetExtension(filename))
						{
							case ".png":
								format = TextureFormat.ARGB32;
								break;
							case ".jpg":
							case ".jpeg":
								format = TextureFormat.RGB24;
								break;
							default:
							case ".dds":
								format = TextureFormat.DXT5;
								break;
						}

						TexFile file = new TexFile(internalPath, format, new Size(image.Width, image.Height));
						file.Data = data;

						string outputFilename = Path.ChangeExtension(filename, ".tex");
					
						using (var output = new FileStream(outputFilename, FileMode.Create))
							file.WriteFile(output);
					}
				}
			}
		}

		private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog
			{
				Filter = "Texture file (*.tex)|*.tex|All Files (*.*)|*.*",
				Multiselect = true
			};

			if (open.ShowDialog() != DialogResult.OK)
				return;

			foreach (string filename in open.FileNames)
			{
				using (FileStream fs = new FileStream(filename, FileMode.Open))
				{
					TexFile file = TexFile.ReadFile(fs);

					string outputFilename;

					switch (file.Format)
					{
						case TextureFormat.ARGB32:
							outputFilename = Path.ChangeExtension(filename, ".png");
							break;
						case TextureFormat.RGB24:
							outputFilename = Path.ChangeExtension(filename, ".jpeg");
							break;
						default:
						case TextureFormat.DXT1:
						case TextureFormat.DXT5:
							outputFilename = Path.ChangeExtension(filename, ".dds");
							break;
					}

					File.WriteAllBytes(outputFilename, file.Data);
				}
			}
		}

		#endregion
	}
}
